// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDateSourceGenerationsResponseBodyResult> Result { get; set; }
        public class ListDateSourceGenerationsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The offline deployment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public int? BuildDeployId { get; set; }

            /// <summary>
            /// <para>The start time of the build index operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1626143673</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The storage path of the dump table index file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdfs://opensearch/dump.json</para>
            /// </summary>
            [NameInMap("dataDumpRoot")]
            [Validation(Required=false)]
            public string DataDumpRoot { get; set; }

            /// <summary>
            /// <para>The full index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1626143930</para>
            /// </summary>
            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            /// <summary>
            /// <para>The export type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>api (default): restores to HDFS.</description></item>
            /// <item><description>oss: exports to OSS.</description></item>
            /// <item><description>odps: exports to ODPS.</description></item>
            /// </list>
            /// <para>This parameter has a value only when the dump table is restored from an index. The value is empty for common tables.</para>
            /// </summary>
            [NameInMap("outPutType")]
            [Validation(Required=false)]
            public string OutPutType { get; set; }

            /// <summary>
            /// <para>Key: the index name. Value: the number of shards.</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public Dictionary<string, int?> Partition { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STOPPED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The incremental timestamp.</para>
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
