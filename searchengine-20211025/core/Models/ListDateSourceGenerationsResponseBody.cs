// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDateSourceGenerationsResponseBodyResult> Result { get; set; }
        public class ListDateSourceGenerationsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the offline deployment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public int? BuildDeployId { get; set; }

            /// <summary>
            /// <para>The timestamp that was generated when the index building was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1626143673</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The path of the dumped index in the Apsara File Storage for HDFS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("dataDumpRoot")]
            [Validation(Required=false)]
            public string DataDumpRoot { get; set; }

            /// <summary>
            /// <para>The ID of the full index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1626143930</para>
            /// </summary>
            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            /// <summary>
            /// <para>The shards of the index version. The value is a key-value pair in which the key indicates the index name and the value indicates the number of shards. The number of value shards.</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public Dictionary<string, int?> Partition { get; set; }

            /// <summary>
            /// <para>The status of the index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STOPPED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The start timestamp from which incremental data is retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1626143673</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
