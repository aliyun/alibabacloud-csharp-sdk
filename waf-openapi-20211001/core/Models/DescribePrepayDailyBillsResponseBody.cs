// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePrepayDailyBillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The bills of the burstable QPS (pay-as-you-go) feature.</para>
        /// </summary>
        [NameInMap("Bills")]
        [Validation(Required=false)]
        public List<DescribePrepayDailyBillsResponseBodyBills> Bills { get; set; }
        public class DescribePrepayDailyBillsResponseBodyBills : TeaModel {
            /// <summary>
            /// <para>The burstable QPS of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ElasticQpsSetValue")]
            [Validation(Required=false)]
            public long? ElasticQpsSetValue { get; set; }

            /// <summary>
            /// <para>The billing end time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687591200</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The status of QPS usage within the current period of time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: normal.</description></item>
            /// <item><description><b>1</b>: excess.</description></item>
            /// <item><description><b>2</b>: sandbox.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceedStatus")]
            [Validation(Required=false)]
            public int? ExceedStatus { get; set; }

            /// <summary>
            /// <para>The peak QPS within the current period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>The unit price in the bill. The price is measured in CNY for bills at the China site (aliyun.com) and in USD for bills at the international site (alibabacloud.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            /// <summary>
            /// <para>The extended QPS of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <para>The default QPS of the WAF instance.</para>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RiskControl")]
            [Validation(Required=false)]
            public bool? RiskControl { get; set; }

            /// <summary>
            /// <para>The number of times that risk identification is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RiskTraffic")]
            [Validation(Required=false)]
            public long? RiskTraffic { get; set; }

            /// <summary>
            /// <para>The billing start time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687822980</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The actual QPS in total.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The billing types.</para>
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
