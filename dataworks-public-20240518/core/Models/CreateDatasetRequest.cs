// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the dataset. It cannot exceed 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMMON: General (default).</description></item>
        /// <item><description>PIC: Image.</description></item>
        /// <item><description>TEXT: Text.</description></item>
        /// <item><description>TABLE: Table.</description></item>
        /// <item><description>VIDEO: Video.</description></item>
        /// <item><description>AUDIO: Audio.</description></item>
        /// <item><description>INDEX: Index.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The initial version of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InitVersion")]
        [Validation(Required=false)]
        public CreateDatasetRequestInitVersion InitVersion { get; set; }
        public class CreateDatasetRequestInitVersion : TeaModel {
            /// <summary>
            /// <para>The description. It cannot exceed 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initial Version</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The storage import configuration for the dataset. The required configuration information varies based on the storage type.</para>
            /// <details>
            /// <summary>NAS</summary>
            /// For the values, refer to the response of the DescribeFileSystems API operation.
            /// 
            /// <pre><code class="language-JSON">{
            ///   &quot;fileSystemId&quot;: &quot;3b6XXX89c9&quot;, // The ID of the file system.
            ///   &quot;fileSystemStorageType&quot;: &quot;Performance&quot;, // The storage specification of the file system.
            ///   &quot;vpcId&quot;: &quot;vpc-uf66oxxxrqge1t2gson7s&quot; // The VPC ID of the mount target.
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
            /// <para>The mount path. It must start with /mnt/. Default value: /mnt/data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The URL.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-oss-bucket/test_dir/</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The name of the dataset. It must be a non-empty string and cannot exceed 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_oss_dataset</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the dataset. Currently, only DataWorks is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataWorks</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Object Storage Service.</description></item>
        /// <item><description>NAS: General-purpose NAS file storage.</description></item>
        /// <item><description>EXTREMENAS: Extreme NAS file storage.</description></item>
        /// <item><description>DLF_LANCE: Data Lake Formation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
