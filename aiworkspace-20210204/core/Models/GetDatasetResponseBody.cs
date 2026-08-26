// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetResponseBody : TeaModel {
        /// <summary>
        /// <para>The workspace visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: Only the dataset owner and administrators in the workspace can access the dataset.</description></item>
        /// <item><description>PUBLIC: All members in the workspace can access the dataset.</description></item>
        /// <item><description>ROLE_PUBLIC: Only specified workspace roles can access the dataset. For the role list, see AccessibleRoleIdList. The dataset owner and administrators always have access under this condition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The list of workspace role names that can access the dataset. This field takes effect when Accessibility is ROLE_PUBLIC. IDs starting with PAI are basic role IDs, and IDs starting with role- are custom role IDs.</para>
        /// </summary>
        [NameInMap("AccessibleRoleIdList")]
        [Validation(Required=false)]
        public List<string> AccessibleRoleIdList { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Alibaba Cloud Object Storage Service (OSS).</description></item>
        /// <item><description>NAS: Alibaba Cloud Apsara File Storage NAS (NAS).</description></item>
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
        /// <item><description>COMMON: common.</description></item>
        /// <item><description>PIC: image.</description></item>
        /// <item><description>TEXT: text.</description></item>
        /// <item><description>VIDEO: video.</description></item>
        /// <item><description>AUDIO: audio.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>Data for labeling</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The dataset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BASIC: Basic. Does not support dataset file metadata management.</para>
        /// </description></item>
        /// <item><description><para>ADVANCED: Advanced. Only supported for OSS type. Each version supports metadata management for up to 1 million files.</para>
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
        /// <para>The storage import configuration of the dataset. OSS, NAS, and CPFS are supported.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// {<BR>
        /// "region": "${region}",//Region ID<BR>
        /// "bucket": "${bucket}",//Bucket name<BR>
        /// "path": "${path}" //File path<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>NAS</summary>
        /// {<BR>
        /// "region": "${region}",//Region ID<BR>
        /// "fileSystemId": "${file_system_id}", //File system ID<BR>
        /// "path": "${path}", //File system path<BR>
        /// "mountTarget": "${mount_target}" //File system mount target<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>CPFS</summary>
        /// {<BR>
        /// "region": "${region}",//Region ID<BR>
        /// "fileSystemId": "${file_system_id}", //File system ID<BR>
        /// "protocolServiceId":"${protocol_service_id}", //File system protocol service<BR>
        /// "exportId": "${export_id}", //File system export directory<BR>
        /// "path": "${path}", //File system path<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>Lingjun CPFS</summary>
        /// {<BR>
        /// "region": "${region}",//Region ID<BR>
        /// "fileSystemId": "${file_system_id}", //File system ID<BR>
        /// "path": "${path}", //File system path<BR>
        /// "mountTarget": "${mount_target}" //File system mount target, specific to Lingjun edition<BR>
        /// "isVpcMount": boolean, //Whether it is a VPC mount target, specific to Lingjun edition<BR>
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
        /// <para>Indicates whether the dataset is a shared dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The list of labels.</para>
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
        /// <para>The permission when the dataset is mounted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RO: read-only mount.</description></item>
        /// <item><description>RW: read-write mount.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RW</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>The list of workspace role names that have read and write permission on the dataset. IDs starting with PAI are basic role IDs, and IDs starting with role- are custom role IDs. If the list contains &quot;*&quot;, all roles have read and write permission.</para>
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
        /// <para>The extension field of the initial version v1, in JsonString format.
        /// When DLC uses the dataset, you can specify the default mount path of the dataset by configuring the mountPath field.</para>
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
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631044****3440</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The property of the initial dataset version v1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FILE: file.</description></item>
        /// <item><description>DIRECTORY: folder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The dataset provider. If the value is &quot;pai&quot;, the dataset is a PAI platform public dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The data source provider type of the dataset. Valid values:</para>
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
        /// <para>The source relationship of the shared dataset. This field is valid only when IsShared is true.</para>
        /// </summary>
        [NameInMap("SharedFrom")]
        [Validation(Required=false)]
        public DatasetShareRelationship SharedFrom { get; set; }

        /// <summary>
        /// <para>The sharing configuration of the current dataset.</para>
        /// </summary>
        [NameInMap("SharingConfig")]
        [Validation(Required=false)]
        public GetDatasetResponseBodySharingConfig SharingConfig { get; set; }
        public class GetDatasetResponseBodySharingConfig : TeaModel {
            /// <summary>
            /// <para>The list of sharing configuration relationships.</para>
            /// </summary>
            [NameInMap("SharedTo")]
            [Validation(Required=false)]
            public List<DatasetShareRelationship> SharedTo { get; set; }

        }

        /// <summary>
        /// <para>The source dataset ID of the iTag labeling dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rcdg3wxxxxxhc5jk87</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The source dataset version of the labeling dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("SourceDatasetVersion")]
        [Validation(Required=false)]
        public string SourceDatasetVersion { get; set; }

        /// <summary>
        /// <para>The source ID of the initial version v1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is USER, SourceId can be customized.</description></item>
        /// <item><description>If SourceType is ITAG, which indicates a dataset generated from iTAG labeling results, SourceId is the iTAG task ID.</description></item>
        /// <item><description>If SourceType is PAI_PUBLIC_DATASET, which indicates a dataset created from a PAI public dataset, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type of the initial version v1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The labeling template of the iTag labeling dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TextClassification</para>
        /// </summary>
        [NameInMap("TagTemplateType")]
        [Validation(Required=false)]
        public string TagTemplateType { get; set; }

        /// <summary>
        /// <para>The URI of the initial version v1. Example formats:</para>
        /// <list type="bullet">
        /// <item><description>If the data source type is OSS: <c>oss://bucket.endpoint/object</c>.</description></item>
        /// <item><description>If the data source type is NAS:
        /// General-purpose NAS format: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>.
        /// CPFS 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>.
        /// CPFS 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// CPFS 1.0 and CPFS 2.0 are distinguished by the format of the fsid:
        /// CPFS 1.0 format: cpfs-&lt;8 ASCII characters&gt;.
        /// CPFS 2.0 format: cpfs-&lt;16 ASCII characters&gt;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nas://09f****f2.cn-hangzhou/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The ID of the user to whom the dataset belongs.</para>
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
