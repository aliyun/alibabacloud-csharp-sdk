// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePeakTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The QPS statistics of WAF.</para>
        /// </summary>
        [NameInMap("FlowChart")]
        [Validation(Required=false)]
        public List<DescribePeakTrendResponseBodyFlowChart> FlowChart { get; set; }
        public class DescribePeakTrendResponseBodyFlowChart : TeaModel {
            /// <summary>
            /// <para>The number of requests protected by the ACL module. This includes requests that are monitored and blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AclSum")]
            [Validation(Required=false)]
            public long? AclSum { get; set; }

            /// <summary>
            /// <para>The number of requests protected by the scan protection module. This includes requests that are monitored and blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AntiScanSum")]
            [Validation(Required=false)]
            public long? AntiScanSum { get; set; }

            /// <summary>
            /// <para>The number of requests protected by the CC protection module. This includes requests that are monitored and blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcSum")]
            [Validation(Required=false)]
            public long? CcSum { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2622</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The ordinal number for the time point, sorted in chronological order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The number of requests protected by the web attack protection module. This includes requests that are monitored and blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WafSum")]
            [Validation(Required=false)]
            public long? WafSum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D11AC3A-A10C-56E7-A342-E87EC892BAE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
