// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Dataset : TeaModel {
        /// <summary>
        /// <para>The visibility of the dataset in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PRIVATE</c>: Visible only to the dataset\&quot;s owner and administrators.</para>
        /// </description></item>
        /// <item><description><para><c>PUBLIC</c>: The dataset is visible to all users in the workspace.</para>
        /// </description></item>
        /// <item><description><para><c>ROLE_PUBLIC</c>: Visible to specified workspace roles (see <c>AccessibleRoleIdList</c>). The owner and administrators also have visibility.</para>
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
        /// <para>If <c>Accessibility</c> is <c>ROLE_PUBLIC</c>, this parameter lists the IDs of workspace roles that can view the dataset. Role IDs that start with <c>PAI</c> are built-in roles, and those that start with <c>role-</c> are custom roles.</para>
        /// </summary>
        [NameInMap("AccessibleRoleIdList")]
        [Validation(Required=false)]
        public List<string> AccessibleRoleIdList { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
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
        /// <item><description><para><c>COMMON</c>: (Default) Common data.</para>
        /// </description></item>
        /// <item><description><para><c>PIC</c>: Images.</para>
        /// </description></item>
        /// <item><description><para><c>TEXT</c>: Text.</para>
        /// </description></item>
        /// <item><description><para><c>VIDEO</c>: Videos.</para>
        /// </description></item>
        /// <item><description><para><c>AUDIO</c>: Audio.</para>
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
        /// <para>The ID of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-c0h44g3****j8o4348</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of a dataset.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The edition of the dataset. Valid values:</para>
        /// <para><c>BASIC</c>: The basic edition. This edition does not support file metadata management.
        /// <c>ADVANCED</c>: The advanced edition. This edition is supported only for OSS datasets and allows metadata management for up to 1 million files per version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The configuration for importing data from a storage source. Supported sources include OSS, NAS, and CPFS.</para>
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>OSS</para>
        /// </summary>
        /// 
        /// <para>{
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.
        /// &quot;bucket&quot;: &quot;${bucket}&quot;,// The bucket name.
        /// &quot;path&quot;: &quot;${path}&quot; // The file path.
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
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>CPFS</para>
        /// </summary>
        /// 
        /// <para>Content</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>Intelligent Computing CPFS</para>
        /// </summary>
        /// 
        /// <para>Content</para>
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
        /// <para>Indicates whether the dataset is shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>A list of labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>Details of the latest dataset version.</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public DatasetVersion LatestVersion { get; set; }

        /// <summary>
        /// <para>The mount access permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RO RW</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>A list of IDs for workspace roles with read and write permissions on the dataset. Role IDs that start with <c>PAI</c> are built-in roles, and role IDs that start with <c>role-</c> are custom roles. An asterisk (<c>*</c>) indicates that all roles have read and write permissions.</para>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A JSON string of extended options. When you use the dataset in a Data Lake Compute job, you can configure the <c>mountPath</c> field to specify the default mount path for the dataset.</para>
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
        /// <para>Indicates whether the dataset corresponds to a single file or a directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>FILE</c>: The dataset is a file.</para>
        /// </description></item>
        /// <item><description><para><c>DIRECTORY</c>: The dataset is a directory.</para>
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
        /// <para>The type of the data source provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ECS</c> (Default)</para>
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
        /// <para>The source of the shared dataset. This parameter is valid only when <c>IsShared</c> is <c>true</c>.</para>
        /// </summary>
        [NameInMap("SharedFrom")]
        [Validation(Required=false)]
        public DatasetShareRelationship SharedFrom { get; set; }

        /// <summary>
        /// <para>The sharing configuration for the dataset.</para>
        /// </summary>
        [NameInMap("SharingConfig")]
        [Validation(Required=false)]
        public DatasetSharingConfig SharingConfig { get; set; }
        public class DatasetSharingConfig : TeaModel {
            /// <summary>
            /// <para>A list of sharing relationships.</para>
            /// </summary>
            [NameInMap("SharedTo")]
            [Validation(Required=false)]
            public List<DatasetShareRelationship> SharedTo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the source dataset for the annotated dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bvfasdfxxxxj8o411</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The version of the source dataset for the annotated dataset.</para>
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
        /// <para>The source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The annotation template for the iTAG annotated dataset.</para>
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
        /// <item><description><para>OSS data source:
        /// <c>oss://bucket.endpoint/object</c></para>
        /// </description></item>
        /// <item><description><para>General-purpose NAS data source:
        /// <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c></para>
        /// </description></item>
        /// <item><description><para>CPFS 1.0 data source:
        /// <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c></para>
        /// </description></item>
        /// <item><description><para>CPFS 2.0 data source:
        /// <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The format of the <c>fsid</c> distinguishes CPFS 1.0 from CPFS 2.0. A CPFS 1.0 <c>fsid</c> has the format <c>cpfs-&lt;8-character ASCII string&gt;</c>, and a CPFS 2.0 <c>fsid</c> has the format <c>cpfs-&lt;16-character ASCII string&gt;</c>.</para>
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
