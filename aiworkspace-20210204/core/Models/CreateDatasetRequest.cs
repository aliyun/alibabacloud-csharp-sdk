// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The workspace accessibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: The workspace is accessible only to you and the administrator of the workspace. This is the default value.</description></item>
        /// <item><description>PUBLIC: The workspace is accessible to all users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The number of dataset files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>The size of the dataset file. Unit: bytes.</para>
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
        /// <item><description>OSS: Object Storage Service (OSS).</description></item>
        /// <item><description>NAS: File Storage NAS (NAS).</description></item>
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
        /// <para>The type of the dataset. Default value: COMMON. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMMON: common</description></item>
        /// <item><description>PIC: picture</description></item>
        /// <item><description>TEXT: text</description></item>
        /// <item><description>Video: video</description></item>
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
        /// <para>The description of the dataset. Descriptions are used to differentiate datasets.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The dataset configurations to be imported to a storage, such as OSS, NAS, or Cloud Parallel File Storage (CPFS).</para>
        /// <para><b>OSS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;bucket&quot;: &quot;${bucket}&quot;,//The bucket name.\
        /// &quot;path&quot;: &quot;${path}&quot; // The file path.\
        /// }\</para>
        /// <para><b>NAS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The mount point of the file system.\
        /// }\</para>
        /// <para><b>CPFS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;protocolServiceId&quot;:&quot;${protocol_service_id}&quot;, // The file system protocol service.\
        /// &quot;exportId&quot;: &quot;${export_id}&quot;, // The file system export directory.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.\
        /// }\</para>
        /// <para><b>CPFS for Lingjun</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.\
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.\
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.\
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The mount point of the file system, CPFS for Lingjun only.\
        /// &quot;isVpcMount&quot;: boolean, // Whether the mount point is a virtual private cloud (VPC) mount point, CPFS for Lingjun only.\
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
        /// <para>The list of role names in the workspace that have read and write permissions on the mounted database. The names start with PAI are basic role names and the names start with role- are custom role names. If the list contains asterisks (\*), all roles have read and write permissions.</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to [&quot;PAI.AlgoOperator&quot;, &quot;role-hiuwpd01ncrokkgp21&quot;], the account of the specified role is granted the read and write permissions.</description></item>
        /// <item><description>If you set the value to [&quot;\*&quot;], all accounts are granted the read and write permissions.</description></item>
        /// <item><description>If you set the value to [], only the creator of the dataset has the read and write permissions.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The dataset name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter, digit, or Chinese character.</description></item>
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
        /// <para>The extended field, which is a JSON string. When you use the dataset in Deep Learning Containers (DLC), you can configure the mountPath field to specify the default mount path of the dataset.</para>
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
        /// <item><description>FILE</description></item>
        /// <item><description>DIRECTORY</description></item>
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
        /// <para>The dataset provider. The value cannot be set to pai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Github</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The source type of the dataset. Valid values:</para>
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
        /// <para>The data source ID.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to USER, the value of SourceId is a custom string.</description></item>
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
        /// <para>The type of the data source. Default value: USER.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI_PUBLIC_DATASET: a public dataset of PAI.</description></item>
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
        /// <para>The URI of the data source.</para>
        /// <list type="bullet">
        /// <item><description>Value format if DataSourceType is set to OSS: <c>oss://bucket.endpoint/object</c>.</description></item>
        /// <item><description>Value formats if DataSourceType is set to NAS: General-purpose NAS: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>. CPFS 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>. CPFS 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>. You can distinguish CPFS 1.0 and CPFS 2.0 file systems based on the format of the file system ID: The ID for CPFS 1.0 is in the cpfs-&lt;8-bit ASCII characters&gt; format. The ID for CPFS 2.0 is in the cpfs-&lt;16-bit ASCII characters&gt; format.</description></item>
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
        /// <para>The ID of the Alibaba Cloud account to which the dataset belongs. The workspace owner and administrator have permissions to create datasets for specified members in the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2485765****023475</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The description of the dataset of the initial version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The initial version</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The list of tags to be added to the dataset of the initial version.</para>
        /// </summary>
        [NameInMap("VersionLabels")]
        [Validation(Required=false)]
        public List<Label> VersionLabels { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID. If you do not specify this parameter, the default workspace is used. If the default workspace does not exist, an error is reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
