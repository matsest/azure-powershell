namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Vault setting properties.</summary>
    public partial class VaultSettingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingPropertiesInternal
    {

        /// <summary>Backing field for <see cref="MigrationSolutionId" /> property.</summary>
        private string _migrationSolutionId;

        /// <summary>The migration solution ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MigrationSolutionId { get => this._migrationSolutionId; set => this._migrationSolutionId = value; }

        /// <summary>Creates an new <see cref="VaultSettingProperties" /> instance.</summary>
        public VaultSettingProperties()
        {

        }
    }
    /// Vault setting properties.
    public partial interface IVaultSettingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The migration solution ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The migration solution ARM Id.",
        SerializedName = @"migrationSolutionId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationSolutionId { get; set; }

    }
    /// Vault setting properties.
    internal partial interface IVaultSettingPropertiesInternal

    {
        /// <summary>The migration solution ARM Id.</summary>
        string MigrationSolutionId { get; set; }

    }
}