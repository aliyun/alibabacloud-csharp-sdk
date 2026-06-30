// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeModelOperatorResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeModelOperatorResponseBodyData Data { get; set; }
        public class DescribeModelOperatorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The endpoint URL for model requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values: <c>PREPAY</c> (subscription) and <c>POSTPAY</c> (pay-as-you-go).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY / POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The daily token usage.</para>
            /// </summary>
            [NameInMap("DailyUsage")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorResponseBodyDataDailyUsage> DailyUsage { get; set; }
            public class DescribeModelOperatorResponseBodyDataDailyUsage : TeaModel {
                /// <summary>
                /// <para>The date of the usage record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-31</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The number of tokens used on this date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public long? Usage { get; set; }

            }

            /// <summary>
            /// <para>The UNIX timestamp, in milliseconds, indicating when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1775145600000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlarge</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-*********6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The usage of each API key, including deleted keys.</para>
            /// </summary>
            [NameInMap("KeyUsageList")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorResponseBodyDataKeyUsageList> KeyUsageList { get; set; }
            public class DescribeModelOperatorResponseBodyDataKeyUsageList : TeaModel {
                /// <summary>
                /// <para>The API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-*****</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The daily usage for the API key.</para>
                /// </summary>
                [NameInMap("DailyUsage")]
                [Validation(Required=false)]
                public List<DescribeModelOperatorResponseBodyDataKeyUsageListDailyUsage> DailyUsage { get; set; }
                public class DescribeModelOperatorResponseBodyDataKeyUsageListDailyUsage : TeaModel {
                    /// <summary>
                    /// <para>The date of the usage record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-31</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>The number of tokens used by the API key on this date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the API key has been deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fase</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                /// <summary>
                /// <para>The name of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>The type of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                /// <summary>
                /// <para>The total number of tokens used by this API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("KeyUsed")]
                [Validation(Required=false)]
                public string KeyUsed { get; set; }

                /// <summary>
                /// <para>The token usage for the current cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000000</para>
                /// </summary>
                [NameInMap("UsedQuota")]
                [Validation(Required=false)]
                public string UsedQuota { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether prefix caching is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PrefixCacheEnabled")]
            [Validation(Required=false)]
            public bool? PrefixCacheEnabled { get; set; }

            [NameInMap("SessionIds")]
            [Validation(Required=false)]
            public List<string> SessionIds { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp, in milliseconds, indicating when the instance started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1772439028000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active/creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total quota for the current cycle, such as the monthly quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <para>The usage in the current cycle, such as the monthly usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
