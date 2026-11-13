// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DatasetVersion : TeaModel {
        /// <summary>
        /// <para>The dataset version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial version</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736756055000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17815XXX61016173</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The associated dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks-datasetVersion:0gfxxxjx155usz3hrv</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The dataset version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks-datasetVersion:0gfxxxjx155usz3hrv:1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. The required configuration information varies based on the storage type.</para>
        /// <details>
        /// <summary>NAS</summary>
        /// For valid values, refer to the response of the DescribeFileSystems API operation.
        /// 
        /// <pre><code class="language-JSON">{
        ///   &quot;fileSystemId&quot;: &quot;3b6XXX89c9&quot;, // File system ID
        ///   &quot;fileSystemStorageType&quot;: &quot;Performance&quot;, // Storage specification of the file system
        ///   &quot;vpcId&quot;: &quot;vpc-uf66oxxxrqge1t2gson7s&quot; // VPC ID of the mount target
        /// }
        /// </c></pre>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fileSystemId&quot;:&quot;3b6XXX89c9&quot;,&quot;fileSystemStorageType&quot;:&quot;Performance&quot;,&quot;vpcId&quot;:&quot;vpc-uf66oxxxrqge1t2gson7s&quot;}</para>
        /// </summary>
        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> ImportInfo { get; set; }

        /// <summary>
        /// <para>The PAI dataset labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<DatasetLabel> Labels { get; set; }

        /// <summary>
        /// <para>The modification timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736756055000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The mount path. Default value: /mnt/data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>The storage type. This property is read-only and remains consistent with the corresponding property of the associated dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-oss-bucket/test_dir/</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The dataset version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VersionNumber")]
        [Validation(Required=false)]
        public int? VersionNumber { get; set; }

    }

}
