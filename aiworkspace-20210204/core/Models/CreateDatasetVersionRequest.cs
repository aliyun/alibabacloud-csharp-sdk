// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetVersionRequest : TeaModel {
        /// <summary>
        /// <para>The number of files in the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>The size of the space occupied by the dataset files. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The type of the data source. If you specify multiple types, separate them with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NAS: The data is stored in Alibaba Cloud File Storage (NAS).</para>
        /// </description></item>
        /// <item><description><para>OSS: The data is stored in Alibaba Cloud Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para>CPFS</para>
        /// </description></item>
        /// </list>
        /// <para>Note: The DataSourceType of the version must be the same as the DataSourceType of the dataset. The system verifies this consistency when you create the version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>A custom description for the dataset version. This helps distinguish different dataset versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset version.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. Supported storage types include OSS, NAS, and CPFS.</para>
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>OSS</para>
        /// </summary>
        /// 
        /// <para>{<br>
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.<br>
        /// &quot;bucket&quot;: &quot;${bucket}&quot;,// The bucket name.<br>
        /// &quot;path&quot;: &quot;${path}&quot; // The file path.<br>
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
        /// <para>{<br>
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.<br>
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.<br>
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.<br>
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot; // The mount target of the file system.<br>
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
        /// <para>{<br>
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.<br>
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.<br>
        /// &quot;protocolServiceId&quot;:&quot;${protocol_service_id}&quot;, // The protocol service of the file system.<br>
        /// &quot;exportId&quot;: &quot;${export_id}&quot;, // The exported directory of the file system.<br>
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.<br>
        /// }</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>Intelligent Computing CPFS</para>
        /// </summary>
        /// 
        /// <para>{<br>
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID.<br>
        /// &quot;fileSystemId&quot;: &quot;${file_system_id}&quot;, // The file system ID.<br>
        /// &quot;path&quot;: &quot;${path}&quot;, // The file system path.<br>
        /// &quot;mountTarget&quot;: &quot;${mount_target}&quot;, // The mount target of the file system. This parameter is specific to the Intelligent Computing edition.<br>
        /// &quot;isVpcMount&quot;: boolean, // Specifies whether the mount target is in a VPC. This parameter is specific to the Intelligent Computing edition.<br>
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
        /// <para>A list of tags for the dataset version.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The extended field, which is a JSON string.
        /// When DLC uses the dataset, you can configure the mountPath field to specify the default mount path for the dataset.</para>
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
        /// <item><description><para>DIRECTORY: A folder.</para>
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
        /// <para>The ID of the data source.</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is set to USER, you can customize the SourceId.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to ITAG, which indicates a dataset generated from the annotation results of the iTAG module, SourceId is the task ID from iTAG.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to PAI_PUBLIC_DATASET, which indicates a dataset created from a public PAI dataset, SourceId is empty by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-a0xbe5n03bhqof46ce</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the data source. The default value is USER. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PAI-PUBLIC-DATASET: a public dataset from PAI.</para>
        /// </description></item>
        /// <item><description><para>ITAG: a dataset generated from the annotation results of the iTAG module.</para>
        /// </description></item>
        /// <item><description><para>USER: a dataset registered by a user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The following examples show how to configure the URI:</para>
        /// <list type="bullet">
        /// <item><description><para>If the data source type is OSS: <c>oss://bucket.endpoint/object</c></para>
        /// </description></item>
        /// <item><description><para>If the data source type is NAS:
        /// The format for a general-purpose NAS file system is <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>.
        /// CPFS 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>.
        /// CPFS 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// CPFS 1.0 and CPFS 2.0 are distinguished by the format of the fsid. The format for CPFS 1.0 is cpfs-&lt;8 ASCII characters&gt;. The format for CPFS 2.0 is cpfs-&lt;16 ASCII characters&gt;.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
