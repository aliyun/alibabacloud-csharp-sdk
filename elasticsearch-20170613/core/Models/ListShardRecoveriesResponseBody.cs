// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListShardRecoveriesResponseBodyResult> Result { get; set; }
        public class ListShardRecoveriesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The data restoration progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80%</para>
            /// </summary>
            [NameInMap("bytesPercent")]
            [Validation(Required=false)]
            public string BytesPercent { get; set; }

            /// <summary>
            /// <para>The total amount of data that is restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12086</para>
            /// </summary>
            [NameInMap("bytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// <para>The file execution progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80.0%</para>
            /// </summary>
            [NameInMap("filesPercent")]
            [Validation(Required=false)]
            public string FilesPercent { get; set; }

            /// <summary>
            /// <para>The total number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79</para>
            /// </summary>
            [NameInMap("filesTotal")]
            [Validation(Required=false)]
            public long? FilesTotal { get; set; }

            /// <summary>
            /// <para>The name of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-index-000001</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <para>The IP address of the source node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("sourceHost")]
            [Validation(Required=false)]
            public string SourceHost { get; set; }

            /// <summary>
            /// <para>The name of the source node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2Kni3dJ</para>
            /// </summary>
            [NameInMap("sourceNode")]
            [Validation(Required=false)]
            public string SourceNode { get; set; }

            /// <summary>
            /// <para>The data restoration status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>done: Data restoration is complete.</description></item>
            /// <item><description>finalize: Data is being cleared.</description></item>
            /// <item><description>index: Index metadata is being read, and bytes are being copied from source to destination.</description></item>
            /// <item><description>init: Data restoration is not started.</description></item>
            /// <item><description>start: Data restoration is started.</description></item>
            /// <item><description>translog: Translogs are being redone.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>done</para>
            /// </summary>
            [NameInMap("stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <para>The IP address of the destination node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("targetHost")]
            [Validation(Required=false)]
            public string TargetHost { get; set; }

            /// <summary>
            /// <para>The name of the destination node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YVVKLmW</para>
            /// </summary>
            [NameInMap("targetNode")]
            [Validation(Required=false)]
            public string TargetNode { get; set; }

            /// <summary>
            /// <para>The number of translog operations to be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12086</para>
            /// </summary>
            [NameInMap("translogOps")]
            [Validation(Required=false)]
            public long? TranslogOps { get; set; }

            /// <summary>
            /// <para>The restoration progress of translog operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80%</para>
            /// </summary>
            [NameInMap("translogOpsPercent")]
            [Validation(Required=false)]
            public string TranslogOpsPercent { get; set; }

        }

    }

}
