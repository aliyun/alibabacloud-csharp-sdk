// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the dataset in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PRIVATE</c>: The dataset is visible only to its owner and workspace administrators.</para>
        /// </description></item>
        /// <item><description><para><c>PUBLIC</c>: The dataset is visible to all members in the workspace.</para>
        /// </description></item>
        /// <item><description><para><c>ROLE_PUBLIC</c>: The dataset is visible to specific workspace roles. For the list of roles, see the <c>AccessibleRoleIdList</c> parameter. The dataset owner and workspace administrators can always view the dataset.</para>
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
        /// <para>A list of workspace role IDs that can view the dataset. This parameter takes effect only when <c>Accessibility</c> is set to <c>ROLE_PUBLIC</c>. A role ID that starts with <c>PAI</c> is a basic role ID. A role ID that starts with <c>role-</c> is a custom role ID.</para>
        /// </summary>
        [NameInMap("AccessibleRoleIdList")]
        [Validation(Required=false)]
        public List<string> AccessibleRoleIdList { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>OSS</c>: Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para><c>NAS</c>: Apsara File Storage NAS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NAS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The data type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>COMMON</c>: General data</para>
        /// </description></item>
        /// <item><description><para><c>PIC</c>: images</para>
        /// </description></item>
        /// <item><description><para><c>TEXT</c>: text</para>
        /// </description></item>
        /// <item><description><para><c>VIDEO</c>: videos</para>
        /// </description></item>
        /// <item><description><para><c>AUDIO</c>: audio</para>
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
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rbvg5wz****c9ks92</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于标注的数据。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The edition of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>BASIC</c>: The basic edition, which does not support file metadata management.</para>
        /// </description></item>
        /// <item><description><para><c>ADVANCED</c>: The advanced edition, which is supported only for OSS datasets and allows you to manage metadata for up to 1 million files per version.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The time when the dataset was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the dataset was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. Storage services such as OSS, NAS, and CPFS are supported.</para>
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
        /// &quot;path&quot;: &quot;${path}&quot; // The path to the file or folder.\
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
        /// &quot;path&quot;: &quot;${path}&quot;, // The path in the file system.\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The file system mount target.\
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
        /// &quot;protocolServiceId&quot;:&quot;${protocol_service_id}&quot;, // The protocol service ID.\
        /// &quot;exportId&quot;: &quot;${export_id}&quot;, // The export directory ID.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The path in the file system.\
        /// }</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>CPFS for Intelligent Computing</para>
        /// </summary>
        /// 
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The path in the file system.\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The file system mount target. This parameter is specific to CPFS for Intelligent Computing.\
        /// &quot;isVpcMount&quot;: boolean, // Specifies whether the mount target is a VPC mount target. Specific to CPFS for Intelligent Computing.\
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
        /// <para>Indicates whether the dataset is a shared dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The labels attached to the dataset.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The latest version of the dataset.</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public DatasetVersion LatestVersion { get; set; }

        /// <summary>
        /// <para>The mount permissions for the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>RO</c>: read-only mount</para>
        /// </description></item>
        /// <item><description><para><c>RW</c>: read and write mount</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RW</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>A list of workspace role IDs granted read/write permissions for the dataset. A role ID that starts with <c>PAI</c> is a basic role ID. A role ID that starts with <c>role-</c> is a custom role ID. If the list contains <c>*</c>, all roles have read and write permissions.</para>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Extended properties for the initial dataset version (v1), in JSON string format. For example, when using the dataset in a DLC job, you can set the <c>mountPath</c> field to specify the default mount path.</para>
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
        /// <para>The owner ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631044****3440</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The property of the initial dataset version (v1). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>FILE</c>: The dataset is a file.</para>
        /// </description></item>
        /// <item><description><para><c>DIRECTORY</c>: The dataset is a folder.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The provider of the dataset. If the value is <c>pai</c>, the dataset is a PAI public dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The type of the data source provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ECS</c> (default)</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c></para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source from which the dataset was shared. This parameter is returned only if <c>IsShared</c> is <c>true</c>.</para>
        /// </summary>
        [NameInMap("SharedFrom")]
        [Validation(Required=false)]
        public DatasetShareRelationship SharedFrom { get; set; }

        /// <summary>
        /// <para>The sharing configuration for the dataset.</para>
        /// </summary>
        [NameInMap("SharingConfig")]
        [Validation(Required=false)]
        public GetDatasetResponseBodySharingConfig SharingConfig { get; set; }
        public class GetDatasetResponseBodySharingConfig : TeaModel {
            /// <summary>
            /// <para>A list of relationships indicating to whom the dataset is shared.</para>
            /// </summary>
            [NameInMap("SharedTo")]
            [Validation(Required=false)]
            public List<DatasetShareRelationship> SharedTo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the source dataset for the iTAG annotation set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rcdg3wxxxxxhc5jk87</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The version of the source dataset for the annotation set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("SourceDatasetVersion")]
        [Validation(Required=false)]
        public string SourceDatasetVersion { get; set; }

        /// <summary>
        /// <para>The ID of the data source for the initial version (v1). The meaning of this parameter varies based on the <c>SourceType</c> value.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>SourceType</c> is <c>USER</c>, you can specify a custom value for <c>SourceId</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceType</c> is <c>ITAG</c>, the dataset is generated from an iTAG annotation task, and <c>SourceId</c> is the task ID.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceType</c> is <c>PAI_PUBLIC_DATASET</c>, the dataset is created from a PAI public dataset. In this case, <c>SourceId</c> is empty.</para>
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
        /// <para>The source type of the initial dataset version (v1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The annotation template of the iTAG annotation set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TextClassification</para>
        /// </summary>
        [NameInMap("TagTemplateType")]
        [Validation(Required=false)]
        public string TagTemplateType { get; set; }

        /// <summary>
        /// <para>The URI of the initial dataset version (v1). The supported formats are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>For an OSS data source: <c>oss://bucket.endpoint/object</c>.</para>
        /// </description></item>
        /// <item><description><para>For a NAS data source, the format varies by NAS type:</para>
        /// <para>CPFS 1.0 and CPFS 2.0 are distinguished by the format of the file system ID ():</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nas://09f****f2.cn-hangzhou/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The user ID of the dataset owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2485765****023475</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the dataset is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
