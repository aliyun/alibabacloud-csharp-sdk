// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetVersionRequest : TeaModel {
        /// <summary>
        /// <para>The number of dataset files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>The size of the dataset file. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The type of the data source. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NAS: File Storage NAS (NAS).</description></item>
        /// <item><description>OSS: Object Storage Service (OSS).</description></item>
        /// <item><description>CPFS</description></item>
        /// </list>
        /// <para>Note: The DataSourceType value of a dataset version must be the same as that of the dataset. When you create a dataset version, the system checks whether the values are the same.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The description of the dataset. Descriptions are used to differentiate datasets.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The dataset storage import configurations, such as OSS, NAS, and CPFS.</para>
        /// <para><b>OSS</b></para>
        /// <para>{\
        /// &quot;region&quot;: &quot;${region}&quot;,// The region ID\
        /// &quot;bucket&quot;: &quot;${bucket}&quot;,//The bucket name\
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
        /// &quot;path&quot;: &quot;${path}&quot;, // The ile system path\
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
        /// <para>The tags of the dataset version.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The extended field, which is of the JsonString type. When you use the dataset in Deep Learning Containers (DLC), you can use the mountPath field to specify the default mount path of the dataset.</para>
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
        /// <para>The ID of the data source.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to USER, the value of SourceId can be a custom string.</description></item>
        /// <item><description>If SourceType is set to ITAG, the value of SourceId is the ID of the labeling job of iTAG.</description></item>
        /// <item><description>If SourceType is set to PAI_PUBLIC_DATASET, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-a0xbe5n03bhqof46ce</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the data source. Default value: USER. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET: a public dataset of Platform for AI (PAI).</description></item>
        /// <item><description>ITAG: a dataset generated from a labeling job of iTAG.</description></item>
        /// <item><description>USER: a dataset registered by a user.</description></item>
        /// </list>
        /// <para>For each job type:</para>
        /// <list type="bullet">
        /// <item><description>PAI_PUBLIC_DATASET: PAI_PUBLIC_DATASET.</description></item>
        /// <item><description>ITAG: ITAG.</description></item>
        /// <item><description>USER: USER.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Example format:</para>
        /// <list type="bullet">
        /// <item><description>Value format when DataSourceType is set to OSS: <c>oss://bucket.endpoint/object</c>.</description></item>
        /// <item><description>Value formats when DataSourceType is set to NAS: General-purpose NAS: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>. CPFS 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>. CPFS 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>. You can distinguish CPFS 1.0 and CPFS 2.0 file systems based on the format of the file system ID: The ID for CPFS 1.0 is in the cpfs-&lt;8-bit ASCII characters&gt; format. The ID for CPFS 2.0 is in the cpfs-&lt;16-bit ASCII characters&gt; format.</description></item>
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
