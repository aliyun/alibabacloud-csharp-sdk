// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class RerankResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed information returned by the interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Rerank results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public RerankResponseBodyResults Results { get; set; }
        public class RerankResponseBodyResults : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RerankResponseBodyResultsResults> Results { get; set; }
            public class RerankResponseBodyResultsResults : TeaModel {
                /// <summary>
                /// <para>Re-ordered document information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADBPG is the OLAP database of Alibaba Cloud.</para>
                /// </summary>
                [NameInMap("Document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                /// <summary>
                /// <para>Index of this document in the request parameter Documents, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>Rerank similarity score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31412</para>
                /// </summary>
                [NameInMap("RelevanceScore")]
                [Validation(Required=false)]
                public float? RelevanceScore { get; set; }

            }

        }

        /// <summary>
        /// <para>API execution status, value description:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Execution succeeded.</description></item>
        /// <item><description><b>fail</b>: Execution failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Number of consumed tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Tokens")]
        [Validation(Required=false)]
        public int? Tokens { get; set; }

    }

}
