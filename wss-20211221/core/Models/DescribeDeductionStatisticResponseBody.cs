// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeductionStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The deduction data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDeductionStatisticResponseBodyData Data { get; set; }
        public class DescribeDeductionStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para><b>The available core-hour packages.</b></para>
            /// </summary>
            [NameInMap("AvailableCorePackages")]
            [Validation(Required=false)]
            public List<DescribeDeductionStatisticResponseBodyDataAvailableCorePackages> AvailableCorePackages { get; set; }
            public class DescribeDeductionStatisticResponseBodyDataAvailableCorePackages : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568857911493620</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-31 23:59:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-31 23:59:59</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-xxxxx</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The group resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CoreHour</para>
                /// </summary>
                [NameInMap("GroupResourceType")]
                [Validation(Required=false)]
                public string GroupResourceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource is a No-Lx resource.</para>
                /// </summary>
                [NameInMap("NoLx")]
                [Validation(Required=false)]
                public bool? NoLx { get; set; }

                /// <summary>
                /// <para>The source of the No-Lx resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无凌霄来源示例值</para>
                /// </summary>
                [NameInMap("NoLxSource")]
                [Validation(Required=false)]
                public string NoLxSource { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>res-xxxxx</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The group resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CoreHour</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The total duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("TotalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// <para>The used duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40000</para>
                /// </summary>
                [NameInMap("UsedTime")]
                [Validation(Required=false)]
                public long? UsedTime { get; set; }

            }

            /// <summary>
            /// <para>The deduction details.</para>
            /// </summary>
            [NameInMap("Deductions")]
            [Validation(Required=false)]
            public List<DescribeDeductionStatisticResponseBodyDataDeductions> Deductions { get; set; }
            public class DescribeDeductionStatisticResponseBodyDataDeductions : TeaModel {
                /// <summary>
                /// <para>The consumption duration in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000</para>
                /// </summary>
                [NameInMap("ConsumeSecond")]
                [Validation(Required=false)]
                public long? ConsumeSecond { get; set; }

                /// <summary>
                /// <para>The deduction date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("DeductionDate")]
                [Validation(Required=false)]
                public string DeductionDate { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudDesktop</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para><b>The usage details.</b></para>
            /// </summary>
            [NameInMap("Usages")]
            [Validation(Required=false)]
            public List<DescribeDeductionStatisticResponseBodyDataUsages> Usages { get; set; }
            public class DescribeDeductionStatisticResponseBodyDataUsages : TeaModel {
                /// <summary>
                /// <para><b>The consumption duration in seconds.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>6000</para>
                /// </summary>
                [NameInMap("ConsumeSecond")]
                [Validation(Required=false)]
                public long? ConsumeSecond { get; set; }

                /// <summary>
                /// <para><b>The time period.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para><b>The resource type.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudDesktop</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
