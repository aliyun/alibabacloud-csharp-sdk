// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The workspace visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: Visible only to the creator and administrators in the workspace. This is the default value.</description></item>
        /// <item><description>PUBLIC: Visible to all users in the workspace.</description></item>
        /// <item><description>ROLE_PUBLIC: Visible to specified workspace roles. For the role list, refer to AccessibleRoleIdList. The dataset owner and administrators always have visibility regardless of the specified roles.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>Takes effect only when Accessibility is set to ROLE_PUBLIC. The list of workspace role names that have visibility to the dataset. Role IDs starting with PAI are basic role IDs, and those starting with role- are custom role IDs.</para>
        /// </summary>
        [NameInMap("AccessibleRoleIdList")]
        [Validation(Required=false)]
        public List<string> AccessibleRoleIdList { get; set; }

        /// <summary>
        /// <para>The number of files in the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>The storage space occupied by the dataset files. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Alibaba Cloud Object Storage Service (OSS).</description></item>
        /// <item><description>NAS: Alibaba Cloud File Storage NAS (General-purpose).</description></item>
        /// <item><description>EXTREMENAS: Alibaba Cloud File Storage NAS (Extreme).</description></item>
        /// <item><description>CPFS: Alibaba Cloud Cloud Paralleled File System (CPFS) (General-purpose).</description></item>
        /// <item><description>BMCPFS: Alibaba Cloud Cloud Paralleled File System (CPFS) (AI-optimized). </description></item>
        /// <item><description>MAXCOMPUTE: Alibaba Cloud MaxCompute.</description></item>
        /// <item><description>URL: A public HTTP or HTTPS URL.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The data type of the dataset. Default value: COMMON. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMMON: Common data.</description></item>
        /// <item><description>PIC: Image data.</description></item>
        /// <item><description>TEXT: Text data.</description></item>
        /// <item><description>VIDEO: Video data.</description></item>
        /// <item><description>AUDIO: Audio data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>DatasetTaskRamRole</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/role-name</para>
        /// </summary>
        [NameInMap("DatasetTaskRamRole")]
        [Validation(Required=false)]
        public string DatasetTaskRamRole { get; set; }

        /// <summary>
        /// <para>The custom description of the dataset, which is used to distinguish it from other datasets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without actually creating the dataset.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The dataset edition. Default value: BASIC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: Basic edition. Does not support file metadata management for the dataset.</description></item>
        /// <item><description>ADVANCED: Advanced edition. Only OSS datasets are supported. Each version supports metadata management for up to 1 million files.</description></item>
        /// <item><description>LOGICAL: Logical edition. Only OSS datasets are supported. Each version supports metadata management for up to 3 million files.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADVANCED</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. OSS, NAS, and CPFS are supported.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// {<BR>
        /// "region": "${region}",// The region ID.<BR>
        /// "bucket": "${bucket}",// The bucket name.<BR>
        /// "path": "${path}" // The file path.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>NAS</summary>
        /// {<BR>
        /// "region": "${region}",// The region ID.<BR>
        /// "fileSystemId": "${file_system_id}", // The file system ID.<BR>
        /// "path": "${path}", // The file system path.<BR>
        /// "mountTarget": "${mount_target}" // The mount target of the file system.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>CPFS</summary>
        /// {<BR>
        /// "region": "${region}",// The region ID.<BR>
        /// "fileSystemId": "${file_system_id}", // The file system ID.<BR>
        /// "protocolServiceId":"${protocol_service_id}", // The protocol service of the file system.<BR>
        /// "exportId": "${export_id}", // The export directory of the file system.<BR>
        /// "path": "${path}", // The file system path.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>AI-optimized CPFS</summary>
        /// {<BR>
        /// "region": "${region}",// The region ID.<BR>
        /// "fileSystemId": "${file_system_id}", // The file system ID.<BR>
        /// "path": "${path}", // The file system path.<BR>
        /// "mountTarget": "${mount_target}", // The mount target of the file system. Specific to the AI-optimized edition.<BR>
        /// "isVpcMount": boolean, // Specifies whether the mount target is a VPC mount target. Specific to the AI-optimized edition.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;region&quot;: &quot;cn-wulanchabu&quot;,
        ///     &quot;fileSystemId&quot;: &quot;bmcpfs-xxxxxxxxxxx&quot;,
        ///     &quot;path&quot;: &quot;/mnt&quot;,
        ///     &quot;mountTarget&quot;: &quot;cpfs-xxxxxxxxxxxx-vpc-gacs9f.cn-wulanchabu.cpfs.aliyuncs.com&quot;,
        ///     &quot;isVpcMount&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public string ImportInfo { get; set; }

        /// <summary>
        /// <para>The list of labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The list of workspace role names that have read and write permissions when the dataset is mounted. Role IDs starting with PAI are basic role IDs, and those starting with role- are custom role IDs. If the list contains an asterisk (*), all roles have read and write permissions.</para>
        /// <list type="bullet">
        /// <item><description>Specified roles: [&quot;PAI.AlgoOperator&quot;, &quot;role-hiuwpd01ncrokkgp21&quot;]</description></item>
        /// <item><description>All roles: [&quot;*&quot;]</description></item>
        /// <item><description>Dataset creator only: []</description></item>
        /// </list>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The name of the dataset. The naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a lowercase letter, an uppercase letter, a digit, or a Chinese character.</description></item>
        /// <item><description>The name can contain underscores (_) and hyphens (-).</description></item>
        /// <item><description>The name must be 1 to 127 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended fields in JSON string format. When DLC uses the dataset, you can configure the mountPath field to specify the default mount path of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;mountPath&quot;: &quot;/mnt/data/&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The property of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FILE: File.</description></item>
        /// <item><description>DIRECTORY: Directory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The provider of the dataset. You cannot set this parameter to pai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Github</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The data source type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ecs: Elastic Compute Service (ECS). This is the default value.</description></item>
        /// <item><description>Lingjun: Lingjun.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>The ID of the source dataset from which the labeled dataset is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bvfasdfxxxxj8o411</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The version of the source dataset from which the labeled dataset is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("SourceDatasetVersion")]
        [Validation(Required=false)]
        public string SourceDatasetVersion { get; set; }

        /// <summary>
        /// <para>The ID of the data source.</para>
        /// <list type="bullet">
        /// <item><description>When SourceType is set to USER, SourceId can be customized.</description></item>
        /// <item><description>When SourceType is set to ITAG, which indicates that the dataset is generated from the labeling results of the iTAG module, SourceId is the iTAG task ID.</description></item>
        /// <item><description>When SourceType is set to PAI_PUBLIC_DATASET, which indicates that the dataset is created from a PAI public dataset, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The data source type. Default value: USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The URI configuration examples are as follows:</para>
        /// <list type="bullet">
        /// <item><description>If the data source type is OSS: <c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>If the data source type is NAS:
        /// For general-purpose NAS, the format is <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>.
        /// For CPFS 1.0, the format is <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>.
        /// For CPFS 2.0, the format is <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// CPFS 1.0 and CPFS 2.0 are distinguished by the format of the fsid: the format for CPFS 1.0 is cpfs-&lt;8 ASCII characters&gt;, and the format for CPFS 2.0 is cpfs-&lt;16 ASCII characters&gt;.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nas://09f****f2.cn-hangzhou/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the dataset owner. The workspace owner and administrators have the permissions to create datasets for specified workspace members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2485765****023475</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>UserMetricsEndpoints</para>
        /// </summary>
        [NameInMap("UserMetricsEndpoints")]
        [Validation(Required=false)]
        public List<UserMetricsEndpoint> UserMetricsEndpoints { get; set; }

        /// <summary>
        /// <para>The description of the initial version of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the first dataset version.</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The list of labels for the initial version.</para>
        /// </summary>
        [NameInMap("VersionLabels")]
        [Validation(Required=false)]
        public List<Label> VersionLabels { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs. For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.
        /// If you do not configure this parameter, the default workspace is used. If the default workspace does not exist, an error is reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
