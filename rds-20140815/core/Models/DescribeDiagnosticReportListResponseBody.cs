// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDiagnosticReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The details of a diagnostic report.</para>
        /// </summary>
        [NameInMap("ReportList")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticReportListResponseBodyReportList> ReportList { get; set; }
        public class DescribeDiagnosticReportListResponseBodyReportList : TeaModel {
            /// <summary>
            /// <para>The time when the diagnosis was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-01-17T12:46:09Z</para>
            /// </summary>
            [NameInMap("DiagnosticTime")]
            [Validation(Required=false)]
            public string DiagnosticTime { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://rdsreport-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx">http://rdsreport-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx</a></para>
            /// </summary>
            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            /// <summary>
            /// <para>The end time of the monitoring data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-01-10T15:31:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The diagnostic score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The start time of the monitoring data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-01-10T15:30:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7E9A79C-DE1B-4398-845F-D654FC0958BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
