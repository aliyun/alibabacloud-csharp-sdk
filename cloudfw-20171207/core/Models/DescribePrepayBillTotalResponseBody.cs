// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrepayBillTotalResponseBody : TeaModel {
        [NameInMap("BillList")]
        [Validation(Required=false)]
        public List<DescribePrepayBillTotalResponseBodyBillList> BillList { get; set; }
        public class DescribePrepayBillTotalResponseBodyBillList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BilledDetectionTraffic")]
            [Validation(Required=false)]
            public float? BilledDetectionTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DailyDetectionTraffic")]
            [Validation(Required=false)]
            public float? DailyDetectionTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DailyOverflowTraffic")]
            [Validation(Required=false)]
            public float? DailyOverflowTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("DefaultBandwidth")]
            [Validation(Required=false)]
            public long? DefaultBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public long? ElasticBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1761667200</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ExtensionBandwidth")]
            [Validation(Required=false)]
            public long? ExtensionBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetTrafficBandwidth")]
            [Validation(Required=false)]
            public float? InternetTrafficBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MonthlyRemainingFreeTraffic")]
            [Validation(Required=false)]
            public float? MonthlyRemainingFreeTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NatTrafficBandwidth")]
            [Validation(Required=false)]
            public float? NatTrafficBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1761588300</para>
            /// </summary>
            [NameInMap("OverflowTime")]
            [Validation(Required=false)]
            public long? OverflowTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1761580800</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TemporaryBandwidth")]
            [Validation(Required=false)]
            public long? TemporaryBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("VpcTrafficBandwidth")]
            [Validation(Required=false)]
            public float? VpcTrafficBandwidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>450D47F5-956E-543E-8502-***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
