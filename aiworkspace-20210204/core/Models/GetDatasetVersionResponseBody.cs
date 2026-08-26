// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The data volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>The dataset size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The primary resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-dkdbnnap0g7b6su4yg</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

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
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset version.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-13T10:22:05.694Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-13T10:22:05.694Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. OSS, NAS, and CPFS are supported.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// {
        /// "region": "${region}",//The region ID.
        /// "bucket": "${bucket}",//The bucket name.
        /// "path": "${path}" //The file path.
        /// }
        /// </details>
        /// 
        /// <details>
        /// <summary>NAS</summary>
        /// 
        /// </details>
        /// 
        /// <details>
        /// <summary>CPFS</summary>
        /// Block content
        /// </details>
        /// 
        /// 
        /// <details>
        /// <summary>Intelligent computing CPFS</summary>
        /// Block content
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
        /// <para>The resource labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The permission when the dataset is mounted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RO: read-only mount</description></item>
        /// <item><description>RW: read and write mount</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RO</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>The extension field.</para>
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
        /// <para>The property of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C55DF3DA-F120-5E37-A374-F49365531701</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The dataset source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The URI configuration example.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ai4d-br7hx9ngzelo2o6uip.oss-cn-shanghai.aliyuncs.com/365349/data-1157703270994901/datasets/aka108o/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        [NameInMap("UserMetricsEndpoints")]
        [Validation(Required=false)]
        public List<UserMetricsEndpoint> UserMetricsEndpoints { get; set; }

        /// <summary>
        /// <para>The dataset version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
