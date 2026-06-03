// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetAuditCountDistributionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>482EF142-BFA5-43FF-B4B0-84A4B0763639</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetAuditCountDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetAuditCountDistributionResponseBodyTimeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 01:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

        }

    }

}
