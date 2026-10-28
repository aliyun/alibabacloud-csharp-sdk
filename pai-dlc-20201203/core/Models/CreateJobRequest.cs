// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Visible to all users in the workspace.</description></item>
        /// <item><description>PRIVATE: Visible only to you and administrators in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The code source used by the job. Before the nodes of the job start, DLC automatically downloads the code configured in the code source and mounts it to a local directory in the container.</para>
        /// </summary>
        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public CreateJobRequestCodeSource CodeSource { get; set; }
        public class CreateJobRequestCodeSource : TeaModel {
            /// <summary>
            /// <para>The branch of the code repository referenced when the job runs. This parameter is optional. By default, the branch configured in the code source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <para>The ID of the code source. &lt;props=&quot;china&quot;&gt;For more information about how to obtain the code source ID, see <a href="https://help.aliyun.com/document_detail/459922.html">ListCodeSources</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-20210111103721-xxxxxxx</para>
            /// </summary>
            [NameInMap("CodeSourceId")]
            [Validation(Required=false)]
            public string CodeSourceId { get; set; }

            /// <summary>
            /// <para>The commit ID of the code to be downloaded for the job. This parameter is optional. By default, the commit ID configured in the code source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44da109b5******</para>
            /// </summary>
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            /// <summary>
            /// <para>Specifies whether the mount path configured for access code source is a shared cloud storage path. If this parameter is set to true, the system enables code clone optimization. In a multi-node job scenario, the clone operation is performed on only one node, and other nodes can directly access access code through the shared cloud storage path.</para>
            /// </summary>
            [NameInMap("IsSharedMountPath")]
            [Validation(Required=false)]
            public bool? IsSharedMountPath { get; set; }

            /// <summary>
            /// <para>The path to be mounted for the job. This parameter is optional. By default, the mount path configured in the code source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

        }

        /// <summary>
        /// <para>The access credential configuration.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The list of custom environment variables.</para>
        /// </summary>
        [NameInMap("CustomEnvs")]
        [Validation(Required=false)]
        public List<CreateJobRequestCustomEnvs> CustomEnvs { get; set; }
        public class CreateJobRequestCustomEnvs : TeaModel {
            /// <summary>
            /// <para>The name of the environment variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUB</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the environment variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keep</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The visibility of the environment variable. A value of public indicates that the variable is public, and a value of private indicates that the variable is private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("Visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

        /// <summary>
        /// <para>The list of data sources used to run the job.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<CreateJobRequestDataSources> DataSources { get; set; }
        public class CreateJobRequestDataSources : TeaModel {
            /// <summary>
            /// <para>The ID of the access point. Currently, only access points of AI CPFS are supported.</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The ID of the data source. &lt;props=&quot;china&quot;&gt;For more information about how to view the data source ID, see <a href="https://help.aliyun.com/document_detail/457222.html">ListDatasets</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cn9dl*******</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The version of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("DataSourceVersion")]
            [Validation(Required=false)]
            public string DataSourceVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the cache service for the data source. This parameter takes effect only when the cluster supports the cache service and a resource group is configured.</para>
            /// </summary>
            [NameInMap("EnableCache")]
            [Validation(Required=false)]
            public bool? EnableCache { get; set; }

            /// <summary>
            /// <para>The permissions when the dataset is mounted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RO: Read-only mount.</description></item>
            /// <item><description>RW: Read/write mount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RO</para>
            /// </summary>
            [NameInMap("MountAccess")]
            [Validation(Required=false)]
            public string MountAccess { get; set; }

            /// <summary>
            /// <para>The path to be mounted for the job. This parameter is optional. By default, the mount path configured in the data source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The mount property of the custom dataset. Currently, only OSS is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;fs.oss.download.thread.concurrency&quot;: &quot;10&quot;,
            ///   &quot;fs.oss.upload.thread.concurrency&quot;: &quot;10&quot;,
            ///   &quot;fs.jindo.args&quot;: &quot;-oattr_timeout=3 -oentry_timeout=0 -onegative_timeout=0 -oauto_cache -ono_symlink&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The ARN of the data source role. This parameter is required when OSS and CPFS access point authentication are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1872xxxxxxxxx:role/account-pai-prod</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The role chain, which is a JSON-formatted string. Example: [{&quot;roleType&quot;:&quot;service&quot;,&quot;roleArn&quot;:&quot;acs:ram::cloud_product_resource_account_uid:role/xxxtodlcrole&quot;,&quot;assumeRoleFor&quot;:&quot;cloud_product_resource_account_uid&quot;},{&quot;roleType&quot;:&quot;user&quot;,&quot;roleArn&quot;:&quot;acs:ram::cloud_product_service_account_uid:role/roletoassumecustomerrole&quot;},{&quot;roleType&quot;:&quot;service&quot;,&quot;roleArn&quot;:&quot;acs:ram::end_user_uid:role/use-bmcpfs-access-ap-role&quot;,&quot;assumeRoleFor&quot;:&quot;end_user_uid&quot;}].</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;roleType&quot;:&quot;service&quot;,&quot;roleArn&quot;:&quot;acs:ram::cloud_product_resource_account_uid:role/xxxtodlcrole&quot;,&quot;assumeRoleFor&quot;:&quot;cloud_product_resource_account_uid&quot;},{&quot;roleType&quot;:&quot;user&quot;,&quot;roleArn&quot;:&quot;acs:ram::cloud_product_service_account_uid:role/roletoassumecustomerrole&quot;},{&quot;roleType&quot;:&quot;service&quot;,&quot;roleArn&quot;:&quot;acs:ram::end_user_uid:role/use-bmcpfs-access-ap-role&quot;,&quot;assumeRoleFor&quot;:&quot;end_user_uid&quot;}]</para>
            /// </summary>
            [NameInMap("RoleChain")]
            [Validation(Required=false)]
            public string RoleChain { get; set; }

            /// <summary>
            /// <para>The path of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>This parameter is not supported. You can ignore it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        /// <summary>
        /// <para>The description of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a training job</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the job. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 256 characters in length.</description></item>
        /// <item><description>The name can contain digits, letters, underscores (_), periods (.), and hyphens (-).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf-mnist-test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run mode.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is not supported. You can ignore it.</para>
        /// </summary>
        [NameInMap("ElasticSpec")]
        [Validation(Required=false)]
        public JobElasticSpec ElasticSpec { get; set; }

        /// <summary>
        /// <para>The environment variable configuration.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The maximum running duration of the job, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("JobMaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? JobMaxRunningTimeMinutes { get; set; }

        /// <summary>
        /// <para><b>JobSpecs</b> describes various configurations when the job runs, such as the image address, startup command, node resource declaration, and number of replicas.</para>
        /// <para>A DLC job consists of different types of nodes. Nodes of the same type have identical configurations, which are called a JobSpec. <b>JobSpecs</b> describes the configurations of all types of nodes and is an array of JobSpecs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The type of the job. This parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TFJob</description></item>
        /// <item><description>PyTorchJob</description></item>
        /// <item><description>MPIJob</description></item>
        /// <item><description>XGBoostJob</description></item>
        /// <item><description>OneFlowJob</description></item>
        /// <item><description>ElasticBatchJob</description></item>
        /// <item><description>SlurmJob</description></item>
        /// <item><description>RayJob</description></item>
        /// <item><description>DataJuicerJob</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The additional configurations for the job. You can use this parameter to adjust the behavior of mounted data sources. For example, if the node has an OSS data source mounted, you can set this parameter to <c>fs.oss.download.thread.concurrency=4,fs.oss.download.queue.size=16</c> to overwrite the default parameter settings of JindoFS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2=value2</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The priority of the job. This parameter is optional. Default value: 1. Valid values: 1 to 9.</para>
        /// <list type="bullet">
        /// <item><description>1: The lowest priority.</description></item>
        /// <item><description>9: The highest priority.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. This parameter is optional.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the job is submitted to a public resource group.</description></item>
        /// <item><description>If you attach a resource quota to the current workspace, you can specify the corresponding resource quota ID here. For details about how to query the resource quota ID, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rs-xxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The scheduling strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("SchedulingStrategy")]
        [Validation(Required=false)]
        public string SchedulingStrategy { get; set; }

        /// <summary>
        /// <para>The additional parameter settings for the job.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <para>The success policy for distributed multi-node jobs. Currently, only multi-node TensorFlow jobs are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ChiefWorker: If this value is specified, the entire job is considered successful as long as the chief pod ends successfully.</description></item>
        /// <item><description>AllWorkers: This is the default value. The entire job is considered successful only when all worker pods end successfully.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllWorkers</para>
        /// </summary>
        [NameInMap("SuccessPolicy")]
        [Validation(Required=false)]
        public string SuccessPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tplabc1234567</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The version of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

        /// <summary>
        /// <para>The name of the folder where the Python third-party library (requirements.txt) file is located. Before each node runs the specified user command, PAI-DLC retrieves the requirements.txt file from the specified folder and runs the <c>pip install -r</c> command to install the libraries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        /// <summary>
        /// <para>The list of Python third-party libraries to be installed.</para>
        /// </summary>
        [NameInMap("ThirdpartyLibs")]
        [Validation(Required=false)]
        public List<string> ThirdpartyLibs { get; set; }

        /// <summary>
        /// <para>The startup command for all nodes of the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python /root/code/mnist.py</para>
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

        /// <summary>
        /// <para>The user VPC configuration.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateJobRequestUserVpc UserVpc { get; set; }
        public class CreateJobRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>The default routing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>eth0: Uses the default network interface controller (NIC) to access external networks through the public gateway.</description></item>
            /// <item><description>eth1: Uses the user elastic network interfaces (ENIs) to access external networks through the private gateway. For the specific configuration method, see <a href="https://help.aliyun.com/document_detail/2525343.html">Configure a DSW instance to access the Internet through a dedicated public gateway</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eth0</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>The extended CIDR blocks.</para>
            /// <list type="bullet">
            /// <item><description>If the vSwitch ID is empty, this parameter is optional. The system automatically retrieves all CIDR blocks in the VPC.</description></item>
            /// <item><description>If the vSwitch ID is not empty, this parameter is required. Specify all CIDR blocks in the VPC.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <para>The ID of the user security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the user vSwitch. This parameter is optional.</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is empty, the system automatically selects an appropriate vSwitch based on inventory.</description></item>
            /// <item><description>You can also specify a vSwitch ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vs-abcdef****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the user VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-abcdef****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-20210126170216-xxxxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
