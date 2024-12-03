// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        public DescribeResourceUsageDetailResponseBodyData Data { get; set; }
        public class DescribeResourceUsageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data entries.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeResourceUsageDetailResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The unit that is used to measure the resources that are deducted.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// <para>The type of the currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The amount of the deducted resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DeductQuantity")]
                [Validation(Required=false)]
                public float? DeductQuantity { get; set; }

                /// <summary>
                /// <para>The end of the time range in which the usage details were queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-01 01:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.t5-lc2m1.nano</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The equivalent of pay-as-you-go costs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.06</para>
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public string PostpaidCost { get; set; }

                /// <summary>
                /// <para>The potential net savings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.13</para>
                /// </summary>
                [NameInMap("PotentialSavedCost")]
                [Validation(Required=false)]
                public string PotentialSavedCost { get; set; }

                /// <summary>
                /// <para>The number of deduction plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

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
                /// <para>The fee of the deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReservationCost")]
                [Validation(Required=false)]
                public string ReservationCost { get; set; }

                /// <summary>
                /// <para>The ID of the deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecsri-bp147nnfz21225k9mpix00</para>
                /// </summary>
                [NameInMap("ResourceInstanceId")]
                [Validation(Required=false)]
                public string ResourceInstanceId { get; set; }

                /// <summary>
                /// <para>The net savings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.06</para>
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public string SavedCost { get; set; }

                /// <summary>
                /// <para>The beginning of the time range in which the usage details were queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the status.</para>
                /// </summary>
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

                /// <summary>
                /// <para>The total capacity of the deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalQuantity")]
                [Validation(Required=false)]
                public float? TotalQuantity { get; set; }

                /// <summary>
                /// <para>The usage rate of the deduction plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
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
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

                /// <summary>
                /// <para>The code of the zone.</para>
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
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
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
        /// <para>The returned message.</para>
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
