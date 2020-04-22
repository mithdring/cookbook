function Get-InstalledSoftware {
    [CmdletBinding()]
    param (
    )
    
    begin {
    }
    
    process {
        Get-ChildItem -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall | `
            Get-ItemProperty -Name Publisher, DisplayName, DisplayVersion -ErrorAction "SilentlyContinue"
    }
    
    end {
    }
}