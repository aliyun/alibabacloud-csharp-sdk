// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the dataset in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIVATE (default): The dataset is visible only to its owner and administrators in the workspace.</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: The dataset is visible to all users in the workspace.</para>
        /// </description></item>
        /// <item><description><para>ROLE_PUBLIC: The dataset is visible to users with specific workspace roles. The list of roles is specified in the <c>AccessibleRoleIdList</c> parameter. The dataset owner and administrators always retain visibility.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only when <c>Accessibility</c> is set to <c>ROLE_PUBLIC</c>. This parameter specifies a list of workspace role IDs that can view this dataset. Role IDs that start with <c>PAI.</c> are built-in roles, and role IDs that start with <c>role-</c> are custom roles.</para>
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
        /// <para>The size of the dataset files, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OSS: Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para>NAS: general-purpose Apsara File Storage NAS.</para>
        /// </description></item>
        /// <item><description><para>EXTREMENAS: Extreme NAS.</para>
        /// </description></item>
        /// <item><description><para>CPFS: general-purpose Cloud Parallel File Storage (CPFS).</para>
        /// </description></item>
        /// <item><description><para>BMCPFS: AI Computing Edition of CPFS.</para>
        /// </description></item>
        /// <item><description><para>MAXCOMPUTE: MaxCompute.</para>
        /// </description></item>
        /// <item><description><para>URL: a public HTTP or HTTPS URL.</para>
        /// </description></item>
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
        /// <para>The data type of the dataset. The default value is <c>COMMON</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>COMMON: common</para>
        /// </description></item>
        /// <item><description><para>PIC: image</para>
        /// </description></item>
        /// <item><description><para>TEXT: text</para>
        /// </description></item>
        /// <item><description><para>VIDEO: video</para>
        /// </description></item>
        /// <item><description><para>AUDIO: audio</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>A custom description to distinguish the dataset from other datasets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The edition of the dataset. The default value is BASIC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BASIC: Basic. Does not support dataset file metadata management.</para>
        /// </description></item>
        /// <item><description><para>ADVANCED: Advanced. Supported only for OSS datasets. Each version supports metadata management for up to 1 million files.</para>
        /// </description></item>
        /// <item><description><para>LOGICAL: Logical. Supported only for OSS datasets. Each version supports metadata management for up to 3 million files.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADVANCED</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. <c>OSS</c>, <c>NAS</c>, and <c>CPFS</c> are supported.</para>
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>OSS</para>
        /// </summary>
        /// 
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;bucket&quot;: &quot;${bucket}&quot;,// The bucket name.\
        /// &quot;path&quot;: &quot;${path}&quot; // The file path.\
        /// }</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>NAS</para>
        /// </summary>
        /// 
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The mount target of the file system.\
        /// }</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>CPFS</para>
        /// </summary>
        /// 
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;protocolServiceId&quot;:&quot;${protocol_service_id}&quot;, // The protocol service of the file system.\
        /// &quot;exportId&quot;: &quot;${export_id}&quot;, // The exported directory of the file system.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.\
        /// }</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>CPFS (AI Computing Edition)</para>
        /// </summary>
        /// 
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot;, // The mount target of the file system. This parameter is specific to the AI Computing Edition.\
        /// &quot;isVpcMount&quot;: boolean, // Specifies whether the mount target is in a VPC. This parameter is specific to the AI Computing Edition.\
        /// }</para>
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
        /// <para>A list of labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>A list of workspace role IDs that are granted read and write permissions when the dataset is mounted. Role IDs that start with <c>PAI.</c> are built-in roles, and role IDs that start with <c>role-</c> are custom roles. If the list contains an asterisk (\*), all roles are granted read and write permissions.</para>
        /// <list type="bullet">
        /// <item><description><para>Accounts with specified roles: <c>[&quot;PAI.AlgoOperator&quot;, &quot;role-hiuwpd01ncrokkgp21&quot;]</c></para>
        /// </description></item>
        /// <item><description><para>All accounts: <c>[&quot;*&quot;]</c></para>
        /// </description></item>
        /// <item><description><para>Dataset creator only: <c>[]</c></para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The name of the dataset. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Starts with a lowercase letter, an uppercase letter, a number, or a Chinese character.</para>
        /// </description></item>
        /// <item><description><para>Can contain underscores (_) and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Must be 1 to 127 characters long.</para>
        /// </description></item>
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
        /// <para>The extended fields, which are a JSON string.
        /// When a Data Lake Compute (DLC) job uses the dataset, you can configure the <c>mountPath</c> field to specify the default mount path of the dataset.</para>
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
        /// <item><description><para>FILE: A file.</para>
        /// </description></item>
        /// <item><description><para>DIRECTORY: A directory.</para>
        /// </description></item>
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
        /// <para>The provider of the dataset. You cannot set this parameter to <c>pai</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Github</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The type of the data source provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Ecs (default)</para>
        /// </description></item>
        /// <item><description><para>Lingjun</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>The ID of the source dataset for a labeled dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bvfasdfxxxxj8o411</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The version of the source dataset for a labeled dataset.</para>
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
        /// <item><description><para>If <c>SourceType</c> is <c>USER</c>, you can specify a custom value for <c>SourceId</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceType</c> is <c>ITAG</c>, this parameter specifies the iTAG task ID from which the dataset was generated.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceType</c> is <c>PAI_PUBLIC_DATASET</c>, the dataset is from a public PAI dataset, and this parameter is empty by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source of the data. The default value is USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The URI of the data. The URI format varies based on the <c>DataSourceType</c> value.</para>
        /// <list type="bullet">
        /// <item><description><para>For an <c>OSS</c> data source: <c>oss://bucket.endpoint/object</c></para>
        /// </description></item>
        /// <item><description><para>For a <c>NAS</c> data source:
        /// For general-purpose <c>NAS</c>: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>.
        /// For <c>CPFS</c> 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>.
        /// For <c>CPFS</c> 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// <c>CPFS</c> 1.0 and <c>CPFS</c> 2.0 are distinguished by the format of the file system ID (fsid). The fsid for <c>CPFS</c> 1.0 is in the <c>cpfs-&lt;8-character ASCII string&gt;</c> format. The fsid for <c>CPFS</c> 2.0 is in the <c>cpfs-&lt;16-character ASCII string&gt;</c> format.</para>
        /// </description></item>
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
        /// <para>The Alibaba Cloud account ID of the dataset owner. Workspace owners and administrators can create datasets for specified members of a workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2485765****023475</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

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
        /// <para>A list of labels for the initial version.</para>
        /// </summary>
        [NameInMap("VersionLabels")]
        [Validation(Required=false)]
        public List<Label> VersionLabels { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.
        /// If this parameter is not specified, the default workspace is used. If the default workspace does not exist, an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
