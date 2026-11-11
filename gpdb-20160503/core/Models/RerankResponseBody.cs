// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class RerankResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public RerankResponseBodyResults Results { get; set; }
        public class RerankResponseBodyResults : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RerankResponseBodyResultsResults> Results { get; set; }
            public class RerankResponseBodyResultsResults : TeaModel {
                [NameInMap("Document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("RelevanceScore")]
                [Validation(Required=false)]
                public float? RelevanceScore { get; set; }

            }

        }

        /// <summary>
        /// <para>The execution status of the API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The operation is successful.</description></item>
        /// <item><description><b>fail</b>: The operation fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of tokens consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Tokens")]
        [Validation(Required=false)]
        public int? Tokens { get; set; }

    }

}
