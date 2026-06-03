// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetRiskLevelDistributionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetRiskLevelDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetRiskLevelDistributionResponseBodyTimeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 01:00:00</para>
            /// </summary>
            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("HighRiskCount")]
            [Validation(Required=false)]
            public long? HighRiskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("LowRiskCount")]
            [Validation(Required=false)]
            public long? LowRiskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("MiddleRiskCount")]
            [Validation(Required=false)]
            public long? MiddleRiskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

        }

    }

}
