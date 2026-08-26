// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): visible only to yourself and administrators within the workspace.</description></item>
        /// <item><description>PUBLIC: visible to all users in the workspace.</description></item>
        /// <item><description>ROLE_PUBLIC: visible to specified workspace roles. For the role list, refer to AccessibleRoleIdList. Under this condition, the dataset owner and administrators always have visibility.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>Takes effect when Accessibility is set to ROLE_PUBLIC. The list of workspace role names that can view the dataset. IDs starting with PAI are basic role IDs, and IDs starting with role- are custom role IDs.</para>
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
        /// <para>The size of space occupied by the dataset files. Unit: bytes.</para>
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
        /// <item><description>NAS: Alibaba Cloud Apsara File Storage NAS General Purpose.</description></item>
        /// <item><description>EXTREMENAS: Alibaba Cloud Apsara File Storage NAS Extreme.</description></item>
        /// <item><description>CPFS: Alibaba Cloud Cloud Parallel File Storage (CPFS) General Purpose.</description></item>
        /// <item><description>BMCPFS: Alibaba Cloud Cloud Parallel File Storage (CPFS) AI Edition. </description></item>
        /// <item><description>MAXCOMPUTE: Alibaba Cloud MaxCompute.</description></item>
        /// <item><description>URL: public HTTP/HTTPS URL.</description></item>
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
        /// <para>DatasetTaskRamRole</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/role-name</para>
        /// </summary>
        [NameInMap("DatasetTaskRamRole")]
        [Validation(Required=false)]
        public string DatasetTaskRamRole { get; set; }

        /// <summary>
        /// <para>The custom description of the dataset to distinguish it from other datasets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The dataset type. Default value: BASIC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: basic. Does not support dataset file metadata management.</description></item>
        /// <item><description>ADVANCED: advanced. Only supported for OSS type. Each version supports up to 1 million file metadata entries.</description></item>
        /// <item><description>LOGICAL: logical. Only supported for OSS type. Each version supports up to 3 million file metadata entries.</description></item>
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
        /// <summary>AI Edition CPFS</summary>
        /// {<BR>
        /// "region": "${region}",//Region ID<BR>
        /// "fileSystemId": "${file_system_id}", //File system ID<BR>
        /// "path": "${path}", //File system path<BR>
        /// "mountTarget": "${mount_target}" //File system mount target, specific to AI Edition<BR>
        /// "isVpcMount": boolean, //Whether it is a VPC mount target, specific to AI Edition<BR>
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
        /// <para>The list of workspace role names that have read and write permissions when the dataset is mounted. IDs starting with PAI are basic role IDs, and IDs starting with role- are custom role IDs. If the list contains &quot;*&quot;, all roles have read and write permissions.</para>
        /// <list type="bullet">
        /// <item><description>Specified roles: [&quot;PAI.AlgoOperator&quot;, &quot;role-hiuwpd01ncrokkgp21&quot;]</description></item>
        /// <item><description>All accounts: [&quot;*&quot;]</description></item>
        /// <item><description>Dataset creator only: []</description></item>
        /// </list>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The name of the dataset. Naming rules:</para>
        /// <list type="bullet">
        /// <item><description>Must start with a lowercase letter, uppercase letter, digit, or Chinese character.</description></item>
        /// <item><description>Can contain underscores (_) or hyphens (-).</description></item>
        /// <item><description>Must be 1 to 127 characters in length.</description></item>
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
        /// <para>The extended field in JsonString format.
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
        /// <para>The property of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FILE: file.</description></item>
        /// <item><description>DIRECTORY: folder.</description></item>
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
        /// <para>The dataset provider. Cannot be set to pai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Github</para>
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
        /// <para>The source dataset ID of the annotation dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bvfasdfxxxxj8o411</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The source dataset version of the annotation dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("SourceDatasetVersion")]
        [Validation(Required=false)]
        public string SourceDatasetVersion { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is USER, SourceId can be customized.</description></item>
        /// <item><description>If SourceType is ITAG, which indicates a dataset generated from iTAG annotation results, SourceId is the iTAG task ID.</description></item>
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
        /// <para>The data source type. Default value: USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Examples of Uri configurations:</para>
        /// <list type="bullet">
        /// <item><description>If the data source type is OSS: <c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>If the data source type is NAS:
        /// General Purpose NAS format: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>;
        /// CPFS 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>;
        /// CPFS 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// CPFS 1.0 and CPFS 2.0 are distinguished by the fsid format: CPFS 1.0 format is cpfs-&lt;8 ASCII characters&gt;; CPFS 2.0 format is cpfs-&lt;16 ASCII characters&gt;.</description></item>
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
        /// <para>The Alibaba Cloud account ID of the dataset owner. Workspace owners and administrators have permissions to create datasets for specified workspace members.</para>
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
        /// <para>The ID of the workspace where the dataset resides. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.
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
