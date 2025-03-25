//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class AzureSqlExtensions
    {
        public static ApplicationModel.IResourceBuilder<Azure.AzureSqlServerResource> AddAzureSqlServer(this IDistributedApplicationBuilder builder, string name) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureSqlDatabaseResource> AddDatabase(this ApplicationModel.IResourceBuilder<Azure.AzureSqlServerResource> builder, string name, string? databaseName = null) { throw null; }

        [System.Obsolete("This method is obsolete and will be removed in a future version. Use AddAzureSqlServer instead to add an Azure SQL server resource.")]
        public static ApplicationModel.IResourceBuilder<ApplicationModel.SqlServerServerResource> AsAzureSqlDatabase(this ApplicationModel.IResourceBuilder<ApplicationModel.SqlServerServerResource> builder) { throw null; }

        [System.Obsolete("This method is obsolete and will be removed in a future version. Use AddAzureSqlServer instead to add an Azure SQL server resource.")]
        public static ApplicationModel.IResourceBuilder<ApplicationModel.SqlServerServerResource> PublishAsAzureSqlDatabase(this ApplicationModel.IResourceBuilder<ApplicationModel.SqlServerServerResource> builder) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureSqlServerResource> RunAsContainer(this ApplicationModel.IResourceBuilder<Azure.AzureSqlServerResource> builder, System.Action<ApplicationModel.IResourceBuilder<ApplicationModel.SqlServerServerResource>>? configureContainer = null) { throw null; }
    }
}

namespace Aspire.Hosting.Azure
{
    public partial class AzureSqlDatabaseResource : ApplicationModel.Resource, ApplicationModel.IResourceWithParent<AzureSqlServerResource>, ApplicationModel.IResourceWithParent, ApplicationModel.IResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        public AzureSqlDatabaseResource(string name, string databaseName, AzureSqlServerResource parent) : base(default!) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public string DatabaseName { get { throw null; } }

        public AzureSqlServerResource Parent { get { throw null; } }
    }

    public partial class AzureSqlServerResource : AzureProvisioningResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IResource, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        [System.Obsolete("This method is obsolete and will be removed in a future version. Use AddAzureSqlServer instead to add an Azure SQL server resource.")]
        public AzureSqlServerResource(ApplicationModel.SqlServerServerResource innerResource, System.Action<AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        public AzureSqlServerResource(string name, System.Action<AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public System.Collections.Generic.IReadOnlyDictionary<string, string> Databases { get { throw null; } }

        public BicepOutputReference FullyQualifiedDomainName { get { throw null; } }

        public override global::Azure.Provisioning.Primitives.ProvisionableResource AddAsExistingResource(AzureResourceInfrastructure infra) { throw null; }

        public override void AddRoleAssignments(IAddRoleAssignmentsContext roleAssignmentContext) { }
    }
}