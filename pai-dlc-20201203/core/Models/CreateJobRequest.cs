// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>The job visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The job is visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: The job is visible only to you and the administrator of the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The code source of the job. Before the node of the job runs, DLC automatically downloads the configured code from the code source and mounts the code to the local path of the container.</para>
        /// </summary>
        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public CreateJobRequestCodeSource CodeSource { get; set; }
        public class CreateJobRequestCodeSource : TeaModel {
            /// <summary>
            /// <para>The branch of the referenced code repository. By default, the branch configured in the code source is used. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <para>The ID of the code source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-20210111103721-xxxxxxx</para>
            /// </summary>
            [NameInMap("CodeSourceId")]
            [Validation(Required=false)]
            public string CodeSourceId { get; set; }

            /// <summary>
            /// <para>The commit ID of the code to be downloaded. By default, the commit ID configured in the code source is used. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44da109b5******</para>
            /// </summary>
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            /// <summary>
            /// <para>The path to which the job is mounted. By default, the mount path configured in the data source is used. This parameter is optional.</para>
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
        /// <para>The data sources for job running.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<CreateJobRequestDataSources> DataSources { get; set; }
        public class CreateJobRequestDataSources : TeaModel {
            /// <summary>
            /// <para>The data source ID.</para>
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

            [NameInMap("MountAccess")]
            [Validation(Required=false)]
            public string MountAccess { get; set; }

            /// <summary>
            /// <para>The path to which the job is mounted. By default, the mount path in the data source configuration is used. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The mount attribute of the custom dataset. Set the value to OSS.</para>
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
        /// <para>This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        /// <summary>
        /// <para>The job name. The name must be in the following format:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 256 characters in length.</description></item>
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
        /// <para>This parameter is not supported.</para>
        /// </summary>
        [NameInMap("ElasticSpec")]
        [Validation(Required=false)]
        public JobElasticSpec ElasticSpec { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The maximum running duration of the job. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("JobMaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? JobMaxRunningTimeMinutes { get; set; }

        /// <summary>
        /// <para>The configurations for job running, such as the image address, startup command, node resource declaration, and number of replicas.****</para>
        /// <para>A DLC job consists of different types of nodes. If nodes of the same type have exactly the same configuration, the configuration is called JobSpec. <b>JobSpecs</b> specifies the configurations of all types of nodes. The value is of the array type.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The job type. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TFJob</description></item>
        /// <item><description>PyTorchJob</description></item>
        /// <item><description>MPIJob</description></item>
        /// <item><description>XGBoostJob</description></item>
        /// <item><description>OneFlowJob</description></item>
        /// <item><description>ElasticBatchJob</description></item>
        /// <item><description>SlurmJob</description></item>
        /// <item><description>RayJob</description></item>
        /// </list>
        /// <para>Valid values for each job type:</para>
        /// <list type="bullet">
        /// <item><description>OneFlowJob: OneFlow.</description></item>
        /// <item><description>PyTorchJob: PyTorch.</description></item>
        /// <item><description>SlurmJob: Slurm.</description></item>
        /// <item><description>XGBoostJob: XGBoost.</description></item>
        /// <item><description>ElasticBatchJob: ElasticBatch.</description></item>
        /// <item><description>MPIJob: MPIJob.</description></item>
        /// <item><description>TFJob: Tensorflow.</description></item>
        /// <item><description>RayJob: Ray.</description></item>
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
        /// <para>The additional configuration of the job. You can use this parameter to adjust the behavior of the attached data source. For example, if the attached data source of the job is of the OSS type, you can use this parameter to add the following configurations to override the default parameters of JindoFS: <c>fs.oss.download.thread.concurrency=4,fs.oss.download.queue.size=16</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2=value2</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The priority of the job. Default value: 1. Valid values: 1 to 9.</para>
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
        /// <para>The ID of the resource group. This parameter is optional.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the job is submitted to a public resource group.</description></item>
        /// <item><description>If a resource quota is associated with the current workspace, you can specify the resource quota ID. For more information about how to query the resource quota ID, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rs-xxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The additional parameter configurations of the job.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <para>The policy that is used to check whether a distributed multi-node job is successful. Only TensorFlow distributed multi-node jobs are supported.</para>
        /// <list type="bullet">
        /// <item><description>ChiefWorker: If you use this policy, the job is considered successful when the pod on the chief node completes operations.</description></item>
        /// <item><description>AllWorkers (default): If you use this policy, the job is considered successful when all worker nodes complete operations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllWorkers</para>
        /// </summary>
        [NameInMap("SuccessPolicy")]
        [Validation(Required=false)]
        public string SuccessPolicy { get; set; }

        /// <summary>
        /// <para>The folder in which the third-party Python library file requirements.txt is stored. Before the startup command specified by the UserCommand parameter is run on each node, DLC fetches the requirements.txt file from the folder and runs <c>pip install -r</c> to install the required package and library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        /// <summary>
        /// <para>The third-party Python libraries to be installed.</para>
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
        /// <para>The VPC settings.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateJobRequestUserVpc UserVpc { get; set; }
        public class CreateJobRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>The default route. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>eth0: The default network interface is used to access the Internet through the public gateway.</description></item>
            /// <item><description>eth1: The user\&quot;s Elastic Network Interface is used to access the Internet through the private gateway. For more information about the configuration method, see <a href="https://help.aliyun.com/document_detail/2525343.html">Enable Internet access for a DSW instance by using a private Internet NAT gateway</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eth0</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>The extended CIDR block.</para>
            /// <list type="bullet">
            /// <item><description>If you leave the SwitchId and ExtendedCIDRs parameters empty, the system automatically obtains all CIDR blocks in a VPC.</description></item>
            /// <item><description>If you configure the SwitchId and ExtendedCIDRs parameters, we recommend that you specify all CIDR blocks in a VPC.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID. This parameter is optional.</para>
            /// <list type="bullet">
            /// <item><description>If you leave this parameter empty, the system automatically selects a vSwitch based on the inventory status.</description></item>
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
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-abcdef****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-20210126170216-xxxxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
