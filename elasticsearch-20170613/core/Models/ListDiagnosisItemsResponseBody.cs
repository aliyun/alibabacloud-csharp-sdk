// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnosisItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDiagnosisItemsResponseBodyResult> Result { get; set; }
        public class ListDiagnosisItemsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The diagnostic item description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>诊断集群写数据是否有堆积当集群的数据写入存在堆积时，会造成BulkReject异常，可能会导致数据丢失，且会造成系统资源消耗严重</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("esApiRequired")]
            [Validation(Required=false)]
            public bool? EsApiRequired { get; set; }

            /// <summary>
            /// <para>The diagnostic item identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterBulkRejectDiagnostic</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The diagnostic item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>索引写入BulkReject诊断</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
