// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeModelOperatorResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeModelOperatorResponseBodyData Data { get; set; }
        public class DescribeModelOperatorResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PREPAY / POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("DailyUsage")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorResponseBodyDataDailyUsage> DailyUsage { get; set; }
            public class DescribeModelOperatorResponseBodyDataDailyUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-31</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public long? Usage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1775145600000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xlarge</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-*********6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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

                [NameInMap("DailyUsage")]
                [Validation(Required=false)]
                public List<DescribeModelOperatorResponseBodyDataKeyUsageListDailyUsage> DailyUsage { get; set; }
                public class DescribeModelOperatorResponseBodyDataKeyUsageListDailyUsage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-31</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fase</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("KeyUsed")]
                [Validation(Required=false)]
                public string KeyUsed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000000</para>
                /// </summary>
                [NameInMap("UsedQuota")]
                [Validation(Required=false)]
                public string UsedQuota { get; set; }

            }

            [NameInMap("PrefixCacheEnabled")]
            [Validation(Required=false)]
            public bool? PrefixCacheEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1772439028000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active/creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
