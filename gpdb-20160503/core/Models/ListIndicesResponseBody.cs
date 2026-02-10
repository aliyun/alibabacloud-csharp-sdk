// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListIndicesResponseBody : TeaModel {
        [NameInMap("Indices")]
        [Validation(Required=false)]
        public ListIndicesResponseBodyIndices Indices { get; set; }
        public class ListIndicesResponseBodyIndices : TeaModel {
            [NameInMap("Indices")]
            [Validation(Required=false)]
            public List<ListIndicesResponseBodyIndicesIndices> Indices { get; set; }
            public class ListIndicesResponseBodyIndicesIndices : TeaModel {
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                [NameInMap("IndexDef")]
                [Validation(Required=false)]
                public string IndexDef { get; set; }

                [NameInMap("IndexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>.</description></item>
        /// <item><description><b>fail</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
