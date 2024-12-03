// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageDetailResponseBody : TeaModel {
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
        /// <para>The return data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansCoverageDetailResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansCoverageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data entries.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansCoverageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeSavingsPlansCoverageDetailResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The coverage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

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
                /// <para>The deducted amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DeductAmount")]
                [Validation(Required=false)]
                public float? DeductAmount { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-05 15:00:00</para>
                /// </summary>
                [NameInMap("EndPeriod")]
                [Validation(Required=false)]
                public string EndPeriod { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spn-a1fhs54c243hP22</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7th_generation_X86_group</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1906589291020438</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The pay-as-you-go cost.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-05 14:00:00</para>
                /// </summary>
                [NameInMap("StartPeriod")]
                [Validation(Required=false)]
                public string StartPeriod { get; set; }

                /// <summary>
                /// <para>The total expenditure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalAmount")]
                [Validation(Required=false)]
                public float? TotalAmount { get; set; }

                /// <summary>
                /// <para>The ID of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2831685687844416</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The username of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:tester1@test.aliyun.com">tester1@test.aliyun.com</a></para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The token of the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
