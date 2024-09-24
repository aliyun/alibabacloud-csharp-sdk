// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizeReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The reports.</para>
        /// </summary>
        [NameInMap("ReportList")]
        [Validation(Required=false)]
        public List<DescribeCustomizeReportListResponseBodyReportList> ReportList { get; set; }
        public class DescribeCustomizeReportListResponseBodyReportList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the report is the default report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The timestamp when the report is pinned. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721836800000</para>
            /// </summary>
            [NameInMap("PinnedTime")]
            [Validation(Required=false)]
            public long? PinnedTime { get; set; }

            /// <summary>
            /// <para>The most recent days for report statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ReportDays")]
            [Validation(Required=false)]
            public int? ReportDays { get; set; }

            /// <summary>
            /// <para>The end date on which the report is sent. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721923199999</para>
            /// </summary>
            [NameInMap("ReportEndDate")]
            [Validation(Required=false)]
            public long? ReportEndDate { get; set; }

            /// <summary>
            /// <para>The ID of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public long? ReportId { get; set; }

            /// <summary>
            /// <para>The start date on which the report is sent. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721836800000</para>
            /// </summary>
            [NameInMap("ReportStartDate")]
            [Validation(Required=false)]
            public long? ReportStartDate { get; set; }

            /// <summary>
            /// <para>The state of the report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <para>The type of the report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: daily report</description></item>
            /// <item><description><b>1</b>: weekly report</description></item>
            /// <item><description><b>2</b>: monthly report</description></item>
            /// <item><description><b>3</b>: report whose statistics are collected in a custom time range</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public int? ReportType { get; set; }

            /// <summary>
            /// <para>The report version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("ReportVersion")]
            [Validation(Required=false)]
            public string ReportVersion { get; set; }

            /// <summary>
            /// <para>The name of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBC6E47-7508-58C9-9E76-528E118CB1CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
