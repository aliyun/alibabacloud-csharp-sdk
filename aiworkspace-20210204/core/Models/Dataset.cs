// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Dataset : TeaModel {
        /// <summary>
        /// <para>The workspace accessibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): The dataset is accessible only to you and the administrator of the workspace.</description></item>
        /// <item><description>PUBLIC: The dataset is accessible to all members in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("AccessibleRoleIdList")]
        [Validation(Required=false)]
        public List<string> AccessibleRoleIdList { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NAS</description></item>
        /// <item><description>OSS</description></item>
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
        /// <item><description>COMMON (default)</description></item>
        /// <item><description>PIC</description></item>
        /// <item><description>TEXT</description></item>
        /// <item><description>Video</description></item>
        /// <item><description>AUDIO</description></item>
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
        /// <para>d-c0h44g3****j8o4348</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The dataset description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
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
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the dataset was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The dataset import information, such as OSS, NAS, and CPFS.</para>
        /// <para><b>OSS</b></para>
        /// <para>{ &quot;region&quot;: &quot;${region}&quot;,//The region ID. &quot;bucket&quot;: &quot;${bucket}&quot;,//The bucket name. &quot;path&quot;: &quot;${path}&quot; //The file path. }</para>
        /// <para><b>NAS</b></para>
        /// <para><b>CPFS</b></para>
        /// <para><b>CPFS for Lingjun</b></para>
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

        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The latest dataset version.</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public DatasetVersion LatestVersion { get; set; }

        /// <summary>
        /// <para>MountAccess</para>
        /// 
        /// <b>Example:</b>
        /// <para>RO RW</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>The IDs of the roles that have read and write permissions on the dataset in the workspace. The IDs starting with PAI is the IDs of the basic roles, and the IDs starting with role- is the IDs of the custom roles. If the list contains &quot;\*&quot;, all roles have read and write permissions.</para>
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
        /// <para>The extended field that can be used as an option. The value is a JSON string. When you use the dataset in Deep Learning Containers (DLC), you can use the mountPath field to specify the default mount path of the dataset.</para>
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
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631044****3440</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The dataset property. Valid values:</para>
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
        /// <para>The provider type of the dataset. Valid values:</para>
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

        [NameInMap("SharedFrom")]
        [Validation(Required=false)]
        public DatasetShareRelationship SharedFrom { get; set; }

        [NameInMap("SharingConfig")]
        [Validation(Required=false)]
        public DatasetSharingConfig SharingConfig { get; set; }
        public class DatasetSharingConfig : TeaModel {
            [NameInMap("SharedTo")]
            [Validation(Required=false)]
            public List<DatasetShareRelationship> SharedTo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the source dataset for the labeled dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bvfasdfxxxxj8o411</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The version of the source dataset for the labeled dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("SourceDatasetVersion")]
        [Validation(Required=false)]
        public string SourceDatasetVersion { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI_PUBLIC_DATASET</description></item>
        /// <item><description>ITAG</description></item>
        /// <item><description>USER</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The labeling template of the iTAG labeled dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-classification</para>
        /// </summary>
        [NameInMap("TagTemplateType")]
        [Validation(Required=false)]
        public string TagTemplateType { get; set; }

        /// <summary>
        /// <para>URI examples:</para>
        /// <list type="bullet">
        /// <item><description>Object Storage Service (OSS) data source: <c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>File Storage NAS (NAS) data source: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c></description></item>
        /// <item><description>Cloud Parallel File Storage (CPFS) 1.0 data source: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c></description></item>
        /// <item><description>CPFS 2.0 data source: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c></description></item>
        /// </list>
        /// <remarks>
        /// <para> You can distinguish CPFS 1.0 and CPFS 2.0 file systems based on the format of the file system ID: The ID of the CPFS 1.0 file system is in the cpfs-&lt;8-bit ASCII characters&gt; format. The ID of the CPFS 2.0 file system is in the cpfs-&lt;16-bit ASCII characters&gt; format.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>nas://09f****f2.cn-hangzhou/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
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
