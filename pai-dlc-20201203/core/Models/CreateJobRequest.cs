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
        /// <item><description>PUBLIC: visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: visible only to you and administrators in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The code source used by this job. Before the job nodes start, DLC automatically downloads the code configured in the code source and mounts it to a local directory of the container.</para>
        /// </summary>
        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public CreateJobRequestCodeSource CodeSource { get; set; }
        public class CreateJobRequestCodeSource : TeaModel {
            /// <summary>
            /// <para>The branch of the code repository referenced at runtime. This parameter is optional. By default, the branch configured in the code source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <para>The code source ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the code source ID, see <a href="https://help.aliyun.com/document_detail/459922.html">ListCodeSources</a>..</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-20210111103721-xxxxxxx</para>
            /// </summary>
            [NameInMap("CodeSourceId")]
            [Validation(Required=false)]
            public string CodeSourceId { get; set; }

            /// <summary>
            /// <para>The commit ID of the code to download for this job. This parameter is optional. By default, the commit ID configured in the code source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44da109b5******</para>
            /// </summary>
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            /// <summary>
            /// <para>The mount path for this job. This parameter is optional. By default, the mount path configured in the code source is used.</para>
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

        [NameInMap("CustomEnvs")]
        [Validation(Required=false)]
        public List<CreateJobRequestCustomEnvs> CustomEnvs { get; set; }
        public class CreateJobRequestCustomEnvs : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

        /// <summary>
        /// <para>The list of data sources used by the job.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<CreateJobRequestDataSources> DataSources { get; set; }
        public class CreateJobRequestDataSources : TeaModel {
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The ID of the data source. &lt;props=&quot;china&quot;&gt;For information about how to obtain the data source ID, see <a href="https://help.aliyun.com/document_detail/457222.html">ListDatasets</a>..</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cn9dl*******</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("DataSourceVersion")]
            [Validation(Required=false)]
            public string DataSourceVersion { get; set; }

            [NameInMap("EnableCache")]
            [Validation(Required=false)]
            public bool? EnableCache { get; set; }

            [NameInMap("MountAccess")]
            [Validation(Required=false)]
            public string MountAccess { get; set; }

            /// <summary>
            /// <para>The mount path for this job. This parameter is optional. By default, the mount path configured in the data source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The custom dataset mount properties. Only OSS is supported.</para>
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

            [NameInMap("RoleChain")]
            [Validation(Required=false)]
            public string RoleChain { get; set; }

            /// <summary>
            /// <para>The data source path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>This parameter is not supported. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the job. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name cannot exceed 256 characters in length.</description></item>
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
        /// <para>This parameter is not supported. Ignore this parameter.</para>
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
        /// <para>The various runtime configurations of the job, such as the image address, startup command, node resource declarations, and number of replicas.</para>
        /// <para>A DLC job consists of different types of nodes. Nodes of the same type share identical configurations, which is called a JobSpec. <b>JobSpecs</b> describes the configurations of all node types and is an array of JobSpec objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The job type. This parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TFJob</description></item>
        /// <item><description>PyTorchJob</description></item>
        /// <item><description>MPIJob</description></item>
        /// <item><description>XGBoostJob</description></item>
        /// <item><description>OneFlowJob</description></item>
        /// <item><description>ElasticBatchJob</description></item>
        /// <item><description>SlurmJob</description></item>
        /// <item><description>RayJob</description></item>
        /// <item><description>DataJuicerJob.</description></item>
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
        /// <para>The additional configuration for this node. You can use this parameter to adjust the behavior of mounted data sources. For example, if the node has an OSS data source mounted, you can set this parameter to <c>fs.oss.download.thread.concurrency=4,fs.oss.download.queue.size=16</c> to overwrite the default JindoFS parameter settings.</para>
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
        /// <item><description>1: the lowest priority.</description></item>
        /// <item><description>9: the highest priority.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter is optional.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the job is submitted to the public resource group.</description></item>
        /// <item><description>If the current workspace has an attached resource quota, you can specify the corresponding resource quota ID. For details about how to query the resource quota ID, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rs-xxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
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
        /// <para>The success policy for distributed multi-node jobs. Only TensorFlow multi-node jobs support this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ChiefWorker: the entire job is considered successful when the Chief pod finishes successfully.</description></item>
        /// <item><description>AllWorkers (default): the entire job is considered successful only when all Worker pods finish successfully.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllWorkers</para>
        /// </summary>
        [NameInMap("SuccessPolicy")]
        [Validation(Required=false)]
        public string SuccessPolicy { get; set; }

        /// <summary>
        /// <para>The job template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tplabc1234567</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The job template version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

        /// <summary>
        /// <para>The name of the folder that contains the third-party Python library file (requirements.txt). Before running the specified UserCommand on each node, PAI-DLC retrieves the requirements.txt file from the specified folder and runs <c>pip install -r</c> to install the libraries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        /// <summary>
        /// <para>The list of third-party Python libraries to install.</para>
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
            /// <item><description>eth0: uses the default network interface controller (NIC) to access external networks through the public gateway.</description></item>
            /// <item><description>eth1: uses the user elastic network interfaces (ENIs) to access external networks through the private gateway. For the specific configuration method, see <a href="https://help.aliyun.com/document_detail/2525343.html">Configure a DSW instance to access the Internet through a dedicated public gateway</a>.</description></item>
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
            /// <item><description>If the vSwitch ID is empty, this parameter is not required. The system automatically obtains all CIDR blocks under the VPC.</description></item>
            /// <item><description>If the vSwitch ID is specified, this parameter is required. Specify all CIDR blocks under the VPC.</description></item>
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
            /// <item><description>If this parameter is left empty, the system automatically selects an appropriate vSwitch based on inventory.</description></item>
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
        /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>..</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-20210126170216-xxxxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
