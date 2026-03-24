// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePrepayDailyBillsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of WAF burstable billing records.</para>
        /// </summary>
        [NameInMap("Bills")]
        [Validation(Required=false)]
        public List<DescribePrepayDailyBillsResponseBodyBills> Bills { get; set; }
        public class DescribePrepayDailyBillsResponseBodyBills : TeaModel {
            /// <summary>
            /// <para>Elastic QPS specification for the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ElasticQpsSetValue")]
            [Validation(Required=false)]
            public long? ElasticQpsSetValue { get; set; }

            /// <summary>
            /// <para>End time of the billing period, in Unix timestamp format (UTC), measured in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687591200</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Overuse status for the current period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Normal.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Overused.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Sandbox.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceedStatus")]
            [Validation(Required=false)]
            public int? ExceedStatus { get; set; }

            /// <summary>
            /// <para>Maximum QPS for the current period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>Unit price for burstable charges. Unit: CNY for the Alibaba Cloud China Website (www\.aliyun.com) and USD for the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            /// <summary>
            /// <para>QPS extension specification for the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <para>QPS specification within the version of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QpsVersion")]
            [Validation(Required=false)]
            public long? QpsVersion { get; set; }

            /// <summary>
            /// <para>Whether Fraud Detection is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Fraud Detection is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Fraud Detection is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RiskControl")]
            [Validation(Required=false)]
            public bool? RiskControl { get; set; }

            /// <summary>
            /// <para>Number of Fraud Detection requests processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RiskTraffic")]
            [Validation(Required=false)]
            public long? RiskTraffic { get; set; }

            /// <summary>
            /// <para>Start time of the billing period, in Unix timestamp format (UTC), measured in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687822980</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Total QPS subject to burstable billing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The billing type.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public List<string> Type { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC10C9EA-A367-52D5-<em><b>-</b></em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
