// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceCoverageDetailResponseBody : TeaModel {
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
        public DescribeResourceCoverageDetailResponseBodyData Data { get; set; }
        public class DescribeResourceCoverageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data entries.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeResourceCoverageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeResourceCoverageDetailResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The unit that is used to measure the resources deducted from deduction plans.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// <para>The code of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The name and billing method of the service.</para>
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// <para>The coverage rate of a deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

                /// <summary>
                /// <para>The currency in which deduction plans were priced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The amount of the resources deducted from a deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DeductQuantity")]
                [Validation(Required=false)]
                public float? DeductQuantity { get; set; }

                /// <summary>
                /// <para>The end of the time range in which the coverage details were queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-01 01:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of a pay-as-you-go instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1d9x623987rlj0dx4xx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The specifications of a deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.t5-lc2m1.nano</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The amount of the bill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PaymentAmount")]
                [Validation(Required=false)]
                public float? PaymentAmount { get; set; }

                /// <summary>
                /// <para>The code of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The code of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-dg-a01</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The beginning of the time range in which the coverage details were queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The total amount of resources consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalQuantity")]
                [Validation(Required=false)]
                public float? TotalQuantity { get; set; }

                /// <summary>
                /// <para>The ID of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123745698925000</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test13@test.aliyun.com">test13@test.aliyun.com</a></para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The code of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

                /// <summary>
                /// <para>The zone.</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
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
