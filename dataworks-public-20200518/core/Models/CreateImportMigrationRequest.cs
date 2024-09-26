// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateImportMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The mapping between the source compute engine instance and the destination compute engine instance. The following types of compute engine instances are supported: MaxCompute, E-MapReduce (EMR), Hadoop CDH, and Hologres.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;ODPS&quot;: {       &quot;zxy_8221431_engine&quot;: &quot;wzp_kaifazheban_engine&quot;     },     &quot;EMR&quot;: {         &quot;aaaa&quot;: &quot;bbb&quot;     }   }</para>
        /// </summary>
        [NameInMap("CalculateEngineMap")]
        [Validation(Required=false)]
        public string CalculateEngineMap { get; set; }

        /// <summary>
        /// <para>The rule configured for automatically committing and deploying the import task. The rule contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>resourceAutoCommit: specifies whether resources are automatically committed. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>resourceAutoDeploy: specifies whether resources are automatically deployed. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>functionAutoCommit: specifies whether the function is automatically committed. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>functionAutoDeploy: specifies whether the function is automatically deployed. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>tableAutoCommitToDev: specifies whether the table is automatically committed to the development environment. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>tableAutoCommitToProd: specifies whether the table is automatically committed to the production environment. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>ignoreLock: specifies whether the lock is automatically ignored when an import task is locked. The value true indicates yes and the value false indicates no. If you set this parameter to true for an import task, you can forcefully update the task even if the task is locked.</description></item>
        /// <item><description>fileAutoCommit: specifies whether the file is automatically committed. The value true indicates yes and the value false indicates no.</description></item>
        /// <item><description>fileAutoDeploy: specifies whether the file is automatically deployed. The value true indicates yes and the value false indicates no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;resourceAutoCommit&quot;: false,     &quot;resourceAutoDeploy&quot;: false,     &quot;functionAutoCommit&quot;: false,     &quot;functionAutoDeploy&quot;: false,     &quot;tableAutoCommitToDev&quot;: false,     &quot;tableAutoCommitToProd&quot;: false,     &quot;ignoreLock&quot;: false,     &quot;fileAutoCommit&quot;: false,     &quot;fileAutoDeploy&quot;: false   }</para>
        /// </summary>
        [NameInMap("CommitRule")]
        [Validation(Required=false)]
        public string CommitRule { get; set; }

        /// <summary>
        /// <para>The description of the import package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the import task. The name must be unique within the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_import_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The path of the import package. <b>The import package must be uploaded. Example of the upload method:</b></para>
        /// <pre><code class="language-java">        Config config = new Config();
        ///         config.setAccessKeyId(accessId);
        ///         config.setAccessKeySecret(accessKey);
        ///         config.setEndpoint(popEndpoint);
        ///         config.setRegionId(regionId);
        /// 
        ///         Client client = new Client(config);
        /// 
        ///         CreateImportMigrationAdvanceRequest request = new CreateImportMigrationAdvanceRequest();
        ///         request.setName(&quot;test_migration_api_&quot; + System.currentTimeMillis());
        ///         request.setProjectId(123456L); 
        ///         request.setPackageType(&quot;DATAWORKS_MODEL&quot;);
        ///         request.setPackageFileObject(new FileInputStream(&quot;/home/admin/Downloads/test.zip&quot;));
        /// 
        ///         RuntimeOptions runtime = new RuntimeOptions();
        ///         CreateImportMigrationResponse response = client.createImportMigrationAdvance(request, runtime);
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/xxx/import.zip</para>
        /// </summary>
        [NameInMap("PackageFile")]
        [Validation(Required=false)]
        public string PackageFile { get; set; }

        /// <summary>
        /// <para>The type of the import package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAWORKS_MODEL (standard format)</description></item>
        /// <item><description>DATAWORKS_V2 (Apsara Stack DataWorks V3.6.1 to V3.11)</description></item>
        /// <item><description>DATAWORKS_V3 (Apsara Stack DataWorks V3.12 and later)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATAWORKS_MODEL</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the Workspace page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The mapping between the resource group for scheduling and the resource group for Data Integration. The keys and values in the mapping are the identifiers of the resource groups. Specify the mapping in the following format:</para>
        /// <pre><code class="language-json">{
        ///     &quot;SCHEDULER_RESOURCE_GROUP&quot;: {
        ///         &quot;xxx&quot;: &quot;yyy&quot;
        ///     },
        ///     &quot;DI_RESOURCE_GROUP&quot;: {
        ///         &quot;ccc&quot;: &quot;dfdd&quot;
        ///     }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SCHEDULER_RESOURCE_GROUP&quot;: {&quot;xxx&quot;:&quot;yyy&quot;},&quot;DI_RESOURCE_GROUP&quot;:{&quot;ccc&quot;:&quot;ddd&quot;}}</para>
        /// </summary>
        [NameInMap("ResourceGroupMap")]
        [Validation(Required=false)]
        public string ResourceGroupMap { get; set; }

        /// <summary>
        /// <para>The mapping between the prefixes for the names of the source and destination workspaces. When the system performs the import operation, the prefix for the name of the source workspace in the import package is replaced based on the mapping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test_workspace_src&quot;: &quot;test_workspace_target&quot;}</para>
        /// </summary>
        [NameInMap("WorkspaceMap")]
        [Validation(Required=false)]
        public string WorkspaceMap { get; set; }

    }

}
