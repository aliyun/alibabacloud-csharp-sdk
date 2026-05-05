// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeductionStatisticResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDeductionStatisticResponseBodyData Data { get; set; }
        public class DescribeDeductionStatisticResponseBodyData : TeaModel {
            [NameInMap("AvailableCorePackages")]
            [Validation(Required=false)]
            public List<DescribeDeductionStatisticResponseBodyDataAvailableCorePackages> AvailableCorePackages { get; set; }
            public class DescribeDeductionStatisticResponseBodyDataAvailableCorePackages : TeaModel {
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-31 23:59:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-31 23:59:59</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>g-xxxxx</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CoreHour</para>
                /// </summary>
                [NameInMap("GroupResourceType")]
                [Validation(Required=false)]
                public string GroupResourceType { get; set; }

                [NameInMap("NoLx")]
                [Validation(Required=false)]
                public bool? NoLx { get; set; }

                [NameInMap("NoLxSource")]
                [Validation(Required=false)]
                public string NoLxSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>res-xxxxx</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CoreHour</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                [NameInMap("UsedTime")]
                [Validation(Required=false)]
                public long? UsedTime { get; set; }

            }

            [NameInMap("Deductions")]
            [Validation(Required=false)]
            public List<DescribeDeductionStatisticResponseBodyDataDeductions> Deductions { get; set; }
            public class DescribeDeductionStatisticResponseBodyDataDeductions : TeaModel {
                [NameInMap("ConsumeSecond")]
                [Validation(Required=false)]
                public long? ConsumeSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("DeductionDate")]
                [Validation(Required=false)]
                public string DeductionDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CloudDesktop</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("Usages")]
            [Validation(Required=false)]
            public List<DescribeDeductionStatisticResponseBodyDataUsages> Usages { get; set; }
            public class DescribeDeductionStatisticResponseBodyDataUsages : TeaModel {
                [NameInMap("ConsumeSecond")]
                [Validation(Required=false)]
                public long? ConsumeSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CloudDesktop</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A1B2C3D4-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
