// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiagnoseReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f07b150eadfa1d7a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeDiagnoseReportResponseBodyReports> Reports { get; set; }
        public class DescribeDiagnoseReportResponseBodyReports : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>196380451****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1727239294</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1727239294</para>
            /// </summary>
            [NameInMap("DiagnoseEndTime")]
            [Validation(Required=false)]
            public long? DiagnoseEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1727229294</para>
            /// </summary>
            [NameInMap("DiagnoseStartTime")]
            [Validation(Required=false)]
            public long? DiagnoseStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Performance</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseReportResponseBodyReportsEvents> Events { get; set; }
            public class DescribeDiagnoseReportResponseBodyReportsEvents : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DiskIOPSExceedDiskMaxLimit</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ResizeDisk</para>
                /// </summary>
                [NameInMap("RecommendAction")]
                [Validation(Required=false)]
                public string RecommendAction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("RecommendParams")]
                [Validation(Required=false)]
                public string RecommendParams { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Warn</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1727239295</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public long? FinishedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>report-sag8d****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d-wz95ycu****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Disk</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Warn</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAA478A0-BEE6-1D42-BEB6-A9CFEAD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
