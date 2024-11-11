// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeDiagnoseReportsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeDiagnoseReportsResponseBodyReports> Reports { get; set; }
        public class DescribeDiagnoseReportsResponseBodyReports : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-23T02:22:30Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseReportsResponseBodyReportsDetails> Details { get; set; }
            public class DescribeDiagnoseReportsResponseBodyReportsDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AccountArrearage</para>
                /// </summary>
                [NameInMap("DiagnoseType")]
                [Validation(Required=false)]
                public string DiagnoseType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VSwitchIdNotFound</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-280ih****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("DiagnoseStatus")]
            [Validation(Required=false)]
            public string DiagnoseStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dr-bp14p0cjp7wvjob5l6hk</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asg-bp124uve5iph3*****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>161456884*******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECA123C6-107B-5F70-A177-740A7224C996</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
