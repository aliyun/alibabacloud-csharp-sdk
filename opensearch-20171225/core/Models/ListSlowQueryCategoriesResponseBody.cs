// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSlowQueryCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4406F40B-A0A2-9D5D-531F-3B6936567584</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSlowQueryCategoriesResponseBodyResult Result { get; set; }
        public class ListSlowQueryCategoriesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The status of the analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: preparing</description></item>
            /// <item><description>SUCCESS: succeeded</description></item>
            /// <item><description>RUNNING: running</description></item>
            /// <item><description>FAILED: failed</description></item>
            /// <item><description>N/A: unknown</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;PENDING&quot;</para>
            /// </summary>
            [NameInMap("analyzeStatus")]
            [Validation(Required=false)]
            public string AnalyzeStatus { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the end of the time range to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589990340</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the beginning of the time range to query.</para>
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
