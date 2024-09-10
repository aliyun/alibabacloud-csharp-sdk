// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizeReportConfigDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the chart that is included in the report. Multiple IDs are separated by commas (,).
        /// </summary>
        [NameInMap("ChartIds")]
        [Validation(Required=false)]
        public string ChartIds { get; set; }

        /// <summary>
        /// The grouping type. Valid values:
        /// 
        /// *   **ALIYUN_RG**
        /// *   **SAS_GROUP**
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// Indicates whether the report is the default report. Valid values:
        /// 
        /// *   **0**: no.
        /// *   **1**: yes.
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public int? IsDefault { get; set; }

        /// <summary>
        /// The time when the report is pinned.
        /// </summary>
        [NameInMap("PinnedTime")]
        [Validation(Required=false)]
        public long? PinnedTime { get; set; }

        /// <summary>
        /// The email address of the recipient. Multiple email addresses are separated by commas (,).
        /// </summary>
        [NameInMap("Recipients")]
        [Validation(Required=false)]
        public string Recipients { get; set; }

        /// <summary>
        /// The most recent days for report statistics.
        /// </summary>
        [NameInMap("ReportDays")]
        [Validation(Required=false)]
        public int? ReportDays { get; set; }

        /// <summary>
        /// The end date on which the report is sent.
        /// </summary>
        [NameInMap("ReportEndDate")]
        [Validation(Required=false)]
        public string ReportEndDate { get; set; }

        /// <summary>
        /// The ID of the report.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// The language of the report. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("ReportLang")]
        [Validation(Required=false)]
        public string ReportLang { get; set; }

        /// <summary>
        /// The time range in which the report is sent. Valid values:
        /// 
        /// *   **1**: 00:00 to 06:00.
        /// *   **2**: 06:00 to 12:00.
        /// *   **3**: 12:00 to 18:00.
        /// *   **4**: 18:00 to 24:00.
        /// </summary>
        [NameInMap("ReportSendType")]
        [Validation(Required=false)]
        public string ReportSendType { get; set; }

        /// <summary>
        /// The start date on which the report is sent.
        /// </summary>
        [NameInMap("ReportStartDate")]
        [Validation(Required=false)]
        public string ReportStartDate { get; set; }

        /// <summary>
        /// The status of the report. Valid values:
        /// 
        /// *   **0**: disabled.
        /// *   **1**: enabled.
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public string ReportStatus { get; set; }

        /// <summary>
        /// The type of the report. Valid values:
        /// 
        /// *   **0**: daily report.
        /// *   **1**: weekly report.
        /// *   **2**: monthly report.
        /// *   **3**: report whose statistics are collected in a custom time range.
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The end time at which the report is sent. The value is in the HH:mm:ss format.
        /// </summary>
        [NameInMap("SendEndTime")]
        [Validation(Required=false)]
        public string SendEndTime { get; set; }

        /// <summary>
        /// The exact day within the sending period.
        /// </summary>
        [NameInMap("SendPeriodDays")]
        [Validation(Required=false)]
        public int? SendPeriodDays { get; set; }

        /// <summary>
        /// The interval at which the report is sent. Valid values:
        /// 
        /// *   **DAY**
        /// *   **WEEK**
        /// *   **MONTH**
        /// </summary>
        [NameInMap("SendPeriodType")]
        [Validation(Required=false)]
        public string SendPeriodType { get; set; }

        /// <summary>
        /// The start time at which the report is sent. The value is in the HH:mm:ss format.
        /// </summary>
        [NameInMap("SendStartTime")]
        [Validation(Required=false)]
        public string SendStartTime { get; set; }

        /// <summary>
        /// The time at which the report is sent. The value is in the HH:mm:ss format.
        /// </summary>
        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public string SendTime { get; set; }

        /// <summary>
        /// The groups.
        /// </summary>
        [NameInMap("TargetGroups")]
        [Validation(Required=false)]
        public string TargetGroups { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account. Multiple IDs are separated by commas (,).
        /// </summary>
        [NameInMap("TargetUids")]
        [Validation(Required=false)]
        public string TargetUids { get; set; }

        /// <summary>
        /// The title of the report.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
