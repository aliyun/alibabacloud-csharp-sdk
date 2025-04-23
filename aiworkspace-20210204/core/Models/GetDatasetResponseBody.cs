// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: The workspace is visible only to you and the administrator of the workspace.</description></item>
        /// <item><description>PUBLIC: The workspace is visible to all users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Object Storage Service (OSS)</description></item>
        /// <item><description>NAS: File Storage NAS (NAS)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NAS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMMON: common</description></item>
        /// <item><description>PIC: picture</description></item>
        /// <item><description>TEXT: text</description></item>
        /// <item><description>VIDEO: video</description></item>
        /// <item><description>AUDIO: audio</description></item>
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
        /// <para>The description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The dataset configurations to be imported to a storage, such as OSS, NAS, or CPFS.</para>
        /// <para><b>OSS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID\
        /// &quot;bucket&quot;: &quot;${bucket}&quot;,// The bucket name\
        /// &quot;path&quot;: &quot;${path}&quot; // The file path\
        /// }\</para>
        /// <para><b>NAS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The mount point of the file system\
        /// }\</para>
        /// <para><b>CPFS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID\
        /// &quot;protocolServiceId&quot;:&quot;${protocol_service_id}&quot;, // The file system protocol service\
        /// &quot;exportId&quot;: &quot;${export_id}&quot;, // The file system export directory\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path\
        /// }\</para>
        /// <para><b>CPFS for Lingjun</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The mount point of the file system, CPFS for Lingjun only\
        /// &quot;isVpcMount&quot;: boolean, // Whether the mount point is a VPC mount point, CPFS for Lingjun only\
        /// }\</para>
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
        /// <para>The tags.</para>
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
        /// <para>The access permission on the dataset when the dataset is mounted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RO: read-only permissions</description></item>
        /// <item><description>RW: read and write permissions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RW</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>The list of role names in the workspace that have read and write permissions on the mounted database. The names start with PAI are basic role names and the names start with role- are custom role names. If the list contains asterisks (\*), all roles have read and write permissions.</para>
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
        /// <para>The extended fields of the dataset v1 (initial version). The value is a JSON string. When you use the dataset in Deep Learning Containers (DLC), you can use the mountPath field to specify the default mount path of the dataset.</para>
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
        /// <para>The ID of the Alibaba Could account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631044****3440</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The property of the dataset of the initial version v1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FILE</description></item>
        /// <item><description>DIRECTORY</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The dataset provider. If the value pai is returned, the dataset is a public dataset in PAI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The type of the data source for the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ecs (default)</description></item>
        /// <item><description>Lingjun</description></item>
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
        /// <para>The ID of the source dataset generated from a labeling job of iTAG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rcdg3wxxxxxhc5jk87</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The version of the source dataset generated from a labeling job of iTAG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("SourceDatasetVersion")]
        [Validation(Required=false)]
        public string SourceDatasetVersion { get; set; }

        /// <summary>
        /// <para>The ID of the source for the dataset v1 (initial version). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to USER, the value of SourceId can be a custom string.</description></item>
        /// <item><description>If SourceType is set to ITAG, the value of SourceId is the ID of the labeling job of iTAG.</description></item>
        /// <item><description>If SourceType is set to PAI_PUBLIC_DATASET, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the source for the dataset v1 (initial version). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET: a public dataset of Platform for AI (PAI).</description></item>
        /// <item><description>ITAG: a dataset generated from a labeling job of iTAG.</description></item>
        /// <item><description>USER: a dataset registered by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The labeling template for the source dataset generated from a labeling job of iTAG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TextClassification</para>
        /// </summary>
        [NameInMap("TagTemplateType")]
        [Validation(Required=false)]
        public string TagTemplateType { get; set; }

        /// <summary>
        /// <para>The URI of the initial version v1.</para>
        /// <list type="bullet">
        /// <item><description>Sample format for the OSS data source: <c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>Sample formats for the NAS data source: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>: General-purpose NAS. <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>: Cloud Parallel File Storage (CPFS) 1.0. <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>: CPFS 2.0. You can distinguish CPFS 1.0 and CPFS 2.0 file systems based on the format of the file system ID. The ID for CPFS 1.0 is in the cpfs-&lt;8-bit ASCII characters&gt; format. The ID for CPFS 2.0 is in the cpfs-&lt;16-bit ASCII characters&gt; format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nas://09f****f2.cn-hangzhou/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The ID of the user to which the dataset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2485765****023475</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
