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
        /// <para>The size of space occupied by dataset files. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The data source type. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NAS: Alibaba Cloud Network Attached Storage (NAS).</para>
        /// </description></item>
        /// <item><description><para>OSS: Alibaba Cloud Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para>CPFS</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The DataSourceType of the version must be consistent with the DataSourceType of the dataset. Validation is performed against the dataset when a version is created.</para>
        /// </remarks>
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
        /// <para>The custom description of the dataset version, used to distinguish different dataset versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset version.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. OSS, NAS, and CPFS are supported.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// {<BR>
        ///   "region": "${region}",//Region ID<BR>
        ///   "bucket": "${bucket}",//Bucket name<BR>
        ///   "path": "${path}" //File path<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>NAS</summary>
        /// {<BR>
        ///   "region": "${region}",//Region ID<BR>
        ///   "fileSystemId": "${file_system_id}", //File system ID<BR>
        ///   "path": "${path}", //File system path<BR>
        ///   "mountTarget": "${mount_target}" //File system mount target<BR>
        /// }<BR>
        /// </details>
        /// 
        /// 
        /// <details>
        /// <summary>CPFS</summary>
        /// {<BR>
        ///   "region": "${region}",//Region ID<BR>
        ///   "fileSystemId": "${file_system_id}", //File system ID<BR>
        ///   "protocolServiceId":"${protocol_service_id}", //File system protocol service<BR>
        ///   "exportId": "${export_id}", //File system export directory<BR>
        ///   "path": "${path}",  //File system path<BR>
        /// }<BR>
        /// </details>
        /// 
        /// <details>
        /// <summary>Lingjun CPFS</summary>
        /// {<BR>
        ///   "region": "${region}",//Region ID<BR>
        ///   "fileSystemId": "${file_system_id}", //File system ID<BR>
        ///   "path": "${path}",  //File system path<BR>
        ///   "mountTarget": "${mount_target}" //File system mount target, specific to Lingjun edition<BR>
        ///   "isVpcMount": boolean, //Whether it is a VPC mount target, specific to Lingjun edition<BR>
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
        /// <para>The list of dataset version labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The extended field in JsonString format.
        /// When DLC uses a dataset, you can specify the default mount path of the dataset by configuring the mountPath field.</para>
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
        /// <para>The data source ID.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is USER, SourceId can be customized.</description></item>
        /// <item><description>If SourceType is ITAG, which indicates a dataset generated from iTAG annotation results, SourceId is the iTAG task ID.</description></item>
        /// <item><description>If SourceType is PAI_PUBLIC_DATASET, which indicates a dataset created from a PAI public dataset, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-a0xbe5n03bhqof46ce</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The data source type. Default value: USER. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET: PAI public dataset.</description></item>
        /// <item><description>ITAG: dataset generated from iTAG annotation results.</description></item>
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
        /// <para>Examples of Uri configurations:</para>
        /// <list type="bullet">
        /// <item><description>If the data source type is OSS: <c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>If the data source type is NAS:
        /// General-purpose NAS format: <c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>;
        /// CPFS 1.0: <c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>;
        /// CPFS 2.0: <c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>.
        /// CPFS 1.0 and CPFS 2.0 are distinguished by the format of the fsid: CPFS 1.0 format is cpfs-&lt;8 ASCII characters&gt;; CPFS 2.0 format is cpfs-&lt;16 ASCII characters&gt;.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        [NameInMap("UserMetricsEndpoints")]
        [Validation(Required=false)]
        public List<UserMetricsEndpoint> UserMetricsEndpoints { get; set; }

    }

}
