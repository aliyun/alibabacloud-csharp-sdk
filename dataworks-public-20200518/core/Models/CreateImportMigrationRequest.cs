// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateImportMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The mapping between the source compute engines and the destination compute engine instances in the import task. Compute engine types include ODPS, EMR, HADOOP_CDH, and HOLOGRES.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;ODPS&quot;: {       &quot;zxy_8221431_engine&quot;: &quot;wzp_kaifazheban_engine&quot;     },     &quot;EMR&quot;: {         &quot;aaaa&quot;: &quot;bbb&quot;     }   }</para>
        /// </summary>
        [NameInMap("CalculateEngineMap")]
        [Validation(Required=false)]
        public string CalculateEngineMap { get; set; }

        /// <summary>
        /// <para>The rules for automatic submission and publishing of tasks during the import operation. The parameters are as follows:</para>
        /// <list type="bullet">
        /// <item><description>resourceAutoCommit: Specifies whether to automatically submit resources. true: yes. false: no.</description></item>
        /// <item><description>resourceAutoDeploy: Specifies whether to automatically publish resources. true: yes. false: no.</description></item>
        /// <item><description>functionAutoCommit: Specifies whether to automatically submit functions. true: yes. false: no.</description></item>
        /// <item><description>functionAutoDeploy: Specifies whether to automatically publish functions. true: yes. false: no.</description></item>
        /// <item><description>tableAutoCommitToDev: Specifies whether to automatically submit tables to the development environment. true: yes. false: no.</description></item>
        /// <item><description>tableAutoCommitToProd: Specifies whether to automatically submit tables to the production environment. true: yes. false: no.</description></item>
        /// <item><description>ignoreLock: Specifies whether to automatically bypass locks. true: yes. false: no. If a task is locked by another user for editing, you can forcibly update the current task by choosing to bypass the lock.</description></item>
        /// <item><description>fileAutoCommit: Specifies whether to automatically submit files. true: yes. false: no.</description></item>
        /// <item><description>fileAutoDeploy: Specifies whether to automatically publish files. true: yes. false: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;resourceAutoCommit&quot;: false,     &quot;resourceAutoDeploy&quot;: false,     &quot;functionAutoCommit&quot;: false,     &quot;functionAutoDeploy&quot;: false,     &quot;tableAutoCommitToDev&quot;: false,     &quot;tableAutoCommitToProd&quot;: false,     &quot;ignoreLock&quot;: false,     &quot;fileAutoCommit&quot;: false,     &quot;fileAutoDeploy&quot;: false   }</para>
        /// </summary>
        [NameInMap("CommitRule")]
        [Validation(Required=false)]
        public string CommitRule { get; set; }

        /// <summary>
        /// <para>The description of the import and export package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the import task to be created. The name must be unique within the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_import_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The path of the import package file.
        /// <b>Note: This operation involves file uploads. The following example shows how to call this operation:</b></para>
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
        /// <para>If you directly pass the file path, the parameter value must be a valid URL of an OSS object within the caller\&quot;s account, such as https://{bucket}.oss-{region}.aliyuncs.com/{object_key}. Cross-account OSS URLs are rejected. If you use the SDK Advance method, you can upload the file by using a local file stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/xxx/import.zip</para>
        /// </summary>
        [NameInMap("PackageFile")]
        [Validation(Required=false)]
        public string PackageFile { get; set; }

        /// <summary>
        /// <para>The type of the import and export package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAWORKS_MODEL: standard format</description></item>
        /// <item><description>DATAWORKS_V2: Apsara Stack (V3.6.1 to V3.11)</description></item>
        /// <item><description>DATAWORKS_V3: Apsara Stack (V3.12 and later)</description></item>
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
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The mapping between schedule resource groups and data integration resource groups. Both the keys and values in the mapping are identifiers of resource groups. The format is as follows:</para>
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
        /// <para>The mapping used to change the input and output workspace names in the import and export package to the mapped workspace names during import and export operations. For example, during an import, the prefixes of the input and output workspace names are replaced based on the mapping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test_workspace_src&quot;: &quot;test_workspace_target&quot;}</para>
        /// </summary>
        [NameInMap("WorkspaceMap")]
        [Validation(Required=false)]
        public string WorkspaceMap { get; set; }

    }

}
