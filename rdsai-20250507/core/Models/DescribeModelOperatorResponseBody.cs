// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeModelOperatorResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeModelOperatorResponseBodyData Data { get; set; }
        public class DescribeModelOperatorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The system API key.</para>
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
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b> (default): Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The URL for model invocation.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The billing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY / POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The daily usage list.</para>
            /// </summary>
            [NameInMap("DailyUsage")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorResponseBodyDataDailyUsage> DailyUsage { get; set; }
            public class DescribeModelOperatorResponseBodyDataDailyUsage : TeaModel {
                /// <summary>
                /// <para>The date (accurate to the day).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-31</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The token usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public long? Usage { get; set; }

            }

            /// <summary>
            /// <para>The end time of the instance. Format: Timestamp.</para>
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
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-*********6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The usage of each key (including deleted keys).</para>
            /// </summary>
            [NameInMap("KeyUsageList")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorResponseBodyDataKeyUsageList> KeyUsageList { get; set; }
            public class DescribeModelOperatorResponseBodyDataKeyUsageList : TeaModel {
                /// <summary>
                /// <para>API Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-*****</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The daily usage of the API key.</para>
                /// </summary>
                [NameInMap("DailyUsage")]
                [Validation(Required=false)]
                public List<DescribeModelOperatorResponseBodyDataKeyUsageListDailyUsage> DailyUsage { get; set; }
                public class DescribeModelOperatorResponseBodyDataKeyUsageListDailyUsage : TeaModel {
                    /// <summary>
                    /// <para>The date (accurate to the day).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-31</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>The number of tokens used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the API key is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fase</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                /// <summary>
                /// <para>The API key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>The key type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                /// <summary>
                /// <para>The total token usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("KeyUsed")]
                [Validation(Required=false)]
                public string KeyUsed { get; set; }

                /// <summary>
                /// <para>The used token quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000000</para>
                /// </summary>
                [NameInMap("UsedQuota")]
                [Validation(Required=false)]
                public string UsedQuota { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the prefix routing persistence feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PrefixCacheEnabled")]
            [Validation(Required=false)]
            public bool? PrefixCacheEnabled { get; set; }

            /// <summary>
            /// <para>The list of headers used for routing persistence. The headers consist of lowercase letters, digits, and hyphens (-).</para>
            /// </summary>
            [NameInMap("SessionIds")]
            [Validation(Required=false)]
            public List<string> SessionIds { get; set; }

            /// <summary>
            /// <para>The start time of the instance. Format: Timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1772439028000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The module status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active/creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total quota for the current cycle (such as the monthly total).</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <para>The used quota for the current cycle (such as the monthly usage).</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
