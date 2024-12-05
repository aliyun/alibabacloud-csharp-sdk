// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetNodeConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetNodeConfigResponseBodyResult Result { get; set; }
        public class GetNodeConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the index is effective online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The number of data replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("dataDuplicateNumber")]
            [Validation(Required=false)]
            public int? DataDuplicateNumber { get; set; }

            /// <summary>
            /// <para>The number of data shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("dataFragmentNumber")]
            [Validation(Required=false)]
            public int? DataFragmentNumber { get; set; }

            /// <summary>
            /// <para>The traffic percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("flowRatio")]
            [Validation(Required=false)]
            public int? FlowRatio { get; set; }

            /// <summary>
            /// <para>The minimum service ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("minServicePercent")]
            [Validation(Required=false)]
            public int? MinServicePercent { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster is mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

        }

    }

}
