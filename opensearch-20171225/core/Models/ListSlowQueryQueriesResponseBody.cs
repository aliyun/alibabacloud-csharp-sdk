// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSlowQueryQueriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB250CA0-ACFD-C5DE-17CD-01445BFE8AE5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSlowQueryQueriesResponseBodyResult Result { get; set; }
        public class ListSlowQueryQueriesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The content of the optimization suggestion for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>no data</para>
            /// </summary>
            [NameInMap("appQuery")]
            [Validation(Required=false)]
            public string AppQuery { get; set; }

            /// <summary>
            /// <para>The end of the time range that was queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589990340</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// <para>The ID of the optimization suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The beginning of the time range that was queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589986800</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

        }

    }

}
