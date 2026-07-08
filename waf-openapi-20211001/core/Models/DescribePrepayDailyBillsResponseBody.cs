// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePrepayDailyBillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of WAF elastic billing records.</para>
        /// </summary>
        [NameInMap("Bills")]
        [Validation(Required=false)]
        public List<DescribePrepayDailyBillsResponseBodyBills> Bills { get; set; }
        public class DescribePrepayDailyBillsResponseBodyBills : TeaModel {
            /// <summary>
            /// <para>The burstable QPS specification of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ElasticQpsSetValue")]
            [Validation(Required=false)]
            public long? ElasticQpsSetValue { get; set; }

            /// <summary>
            /// <para>The end time of the billing period. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687591200</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The overuse status of the current period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Normal.</description></item>
            /// <item><description><b>1</b>: Overused.</description></item>
            /// <item><description><b>2</b>: Sandboxed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceedStatus")]
            [Validation(Required=false)]
            public int? ExceedStatus { get; set; }

            [NameInMap("ExtensionPlugin")]
            [Validation(Required=false)]
            public bool? ExtensionPlugin { get; set; }

            [NameInMap("ExtensionPluginRequest")]
            [Validation(Required=false)]
            public long? ExtensionPluginRequest { get; set; }

            /// <summary>
            /// <para>The maximum QPS during the current period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>The unit price for elastic billing. Unit: CNY for the China site and USD for the international site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            /// <summary>
            /// <para>The QPS extension specification of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <para>The QPS specification included in the WAF instance edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QpsVersion")]
            [Validation(Required=false)]
            public long? QpsVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether risk identification is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Risk identification is enabled.</description></item>
            /// <item><description><b>false</b>: Risk identification is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RiskControl")]
            [Validation(Required=false)]
            public bool? RiskControl { get; set; }

            /// <summary>
            /// <para>The number of times risk identification is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RiskTraffic")]
            [Validation(Required=false)]
            public long? RiskTraffic { get; set; }

            /// <summary>
            /// <para>The start time of the billing period. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687822980</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total QPS that is billed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The elastic billing type.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public List<string> Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC10C9EA-A367-52D5-<em><b>-</b></em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
