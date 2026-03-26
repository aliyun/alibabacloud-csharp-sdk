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
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Creation time (milliseconds)</para>
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
        /// <para>The corresponding dataset ID.</para>
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
        /// <para>The storage import configuration for the dataset; required configuration varies by storage type.</para>
        /// <para><b>NAS</b></para>
        /// <para>Refer to the return values from the file storage API DescribeFileSystems.</para>
        /// <pre><code class="language-JSON">{
        /// &quot;fileSystemId&quot;: &quot;3b6XXX89c9&quot;, // The file system ID.
        /// &quot;fileSystemStorageType&quot;:  &quot;Performance&quot; // The file system storage type.
        /// &quot;vpcId&quot;: &quot;vpc-uf66oxxxrqge1t2gson7s&quot; // The VPC ID of the mount point.
        /// }
        /// </c></pre>
        /// </summary>
        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> ImportInfo { get; set; }

        /// <summary>
        /// <para>The PAI dataset label.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<DatasetLabel> Labels { get; set; }

        /// <summary>
        /// <para>Modification time (milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736756055000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The mount path. Defaults to /mnt/data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>Storage type (read-only); consistent with the corresponding property of the parent dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>URL</para>
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
