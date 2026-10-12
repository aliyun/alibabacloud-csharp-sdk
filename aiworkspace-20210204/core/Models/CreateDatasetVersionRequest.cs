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
        /// <para>The data source type. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NAS: Alibaba Cloud File Storage NAS.</para>
        /// </description></item>
        /// <item><description><para>OSS: Alibaba Cloud Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para>CPFS</para>
        /// </description></item>
        /// </list>
        /// <para>Note: The DataSourceType of the version must be the same as the DataSourceType of the dataset. The system validates this when you create the version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>UserMetricsEndpoints</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/role-name</para>
        /// </summary>
        [NameInMap("DatasetTaskRamRole")]
        [Validation(Required=false)]
        public string DatasetTaskRamRole { get; set; }

        /// <summary>
        /// <para>The custom description of the dataset version. You can use this description to distinguish between different dataset versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset version.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without actually creating the dataset version.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. OSS, NAS, and CPFS are supported.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// {<BR>
        ///   "region": "${region}",// The region ID.<BR>
        ///   "bucket": "${bucket}",// The bucket name.<BR>
        ///   "path": "${path}" // The file path.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>NAS</summary>
        /// {<BR>
        ///   "region": "${region}",// The region ID.<BR>
        ///   "fileSystemId": "${file_system_id}", // The file system ID.<BR>
        ///   "path": "${path}", // The file system path.<BR>
        ///   "mountTarget": "${mount_target}" // The mount target of the file system.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// 
        /// <details>
        /// <summary>CPFS</summary>
        /// {<BR>
        ///   "region": "${region}",// The region ID.<BR>
        ///   "fileSystemId": "${file_system_id}", // The file system ID.<BR>
        ///   "protocolServiceId":"${protocol_service_id}", // The protocol service of the file system.<BR>
        ///   "exportId": "${export_id}", // The export directory of the file system.<BR>
        ///   "path": "${path}",  // The file system path.<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>CPFS for AI computing</summary>
        /// {<BR>
        ///   "region": "${region}",// The region ID.<BR>
        ///   "fileSystemId": "${file_system_id}", // The file system ID.<BR>
        ///   "path": "${path}",  // The file system path.<BR>
        ///   "mountTarget": "${mount_target}" // The mount target of the file system. This parameter is specific to the AI computing edition.<BR>
        ///   "isVpcMount": boolean, // Specifies whether the mount target is a VPC mount target. This parameter is specific to the AI computing edition.<BR>
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
        /// <para>The list of labels for the dataset version.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The extended field. The value is a JSON string. When DLC uses the dataset, you can configure the mountPath field to specify the default mount path for the dataset.</para>
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
        /// <item><description>FILE: file</description></item>
        /// <item><description>DIRECTORY: directory</description></item>
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
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to USER, you can specify a custom SourceId.</description></item>
        /// <item><description>If SourceType is set to ITAG, the dataset is generated from the labeling results of the iTAG module, and SourceId is the task ID in iTAG.</description></item>
        /// <item><description>If SourceType is set to PAI_PUBLIC_DATASET, the dataset is created from a PAI public dataset, and SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-a0xbe5n03bhqof46ce</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type. Default value: USER. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET: PAI public dataset.</description></item>
        /// <item><description>ITAG: dataset generated from the labeling results of the iTAG module.</description></item>
        /// <item><description>USER: user-registered dataset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The URI. Configuration examples:</para>
        /// <list type="bullet">
        /// <item><description>If the data source type is OSS: <c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>If the data source type is NAS:
        /// For general-purpose NAS, the format is <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>.
        /// For CPFS 1.0, the format is <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>.
        /// For CPFS 2.0, the format is <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// CPFS 1.0 and CPFS 2.0 are distinguished by the format of the fsid: the format for CPFS 1.0 is cpfs-&lt;8 ASCII characters&gt;, and the format for CPFS 2.0 is cpfs-&lt;16 ASCII characters&gt;.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The list of user metric collection endpoints.</para>
        /// </summary>
        [NameInMap("UserMetricsEndpoints")]
        [Validation(Required=false)]
        public List<UserMetricsEndpoint> UserMetricsEndpoints { get; set; }

    }

}
