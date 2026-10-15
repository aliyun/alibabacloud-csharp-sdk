// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansUsageDetailResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansUsageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansUsageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeSavingsPlansUsageDetailResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The amount spent from the savings plan, which is the used commitment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.94</para>
                /// </summary>
                [NameInMap("DeductValue")]
                [Validation(Required=false)]
                public float? DeductValue { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-09 00:00:00</para>
                /// </summary>
                [NameInMap("EndPeriod")]
                [Validation(Required=false)]
                public string EndPeriod { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spn-a1fhs54c243hP22</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The total amount of the savings plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29.84</para>
                /// </summary>
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public float? PoolValue { get; set; }

                /// <summary>
                /// <para>The standard pay-as-you-go cost.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.2</para>
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                /// <summary>
                /// <para>The net savings amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.08</para>
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartPeriod")]
                [Validation(Required=false)]
                public string StartPeriod { get; set; }

                /// <summary>
                /// <para>The current status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>-1: overdue payment.</description></item>
                /// <item><description>1: active.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the savings plan, such as general-purpose or ECS compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>General-purpose</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The usage percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

                /// <summary>
                /// <para>The account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123745698925000</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test13@test.aliyun.com">test13@test.aliyun.com</a></para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The token for the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2ldhsSI6MTB9</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of data records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
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
