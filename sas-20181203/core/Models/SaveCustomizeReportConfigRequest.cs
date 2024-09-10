// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveCustomizeReportConfigRequest : TeaModel {
        /// <summary>
        /// The grouping type. Valid values:
        /// 
        /// *   **ALIYUN_RG**
        /// *   **SAS_GROUP**
        /// 
        /// >  This parameter is supported only in version 2.0.0.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The time when the report is pinned. Unit: milliseconds.
        /// 
        /// >  This parameter is supported only in version 2.0.0.
        /// </summary>
        [NameInMap("PinnedTime")]
        [Validation(Required=false)]
        public long? PinnedTime { get; set; }

        /// <summary>
        /// The email address of the recipient. Separate multiple email addresses with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Recipients")]
        [Validation(Required=false)]
        public string Recipients { get; set; }

        /// <summary>
        /// The most recent days for report statistics.
        /// 
        /// >  This parameter is supported only in version 2.0.0.
        /// </summary>
        [NameInMap("ReportDays")]
        [Validation(Required=false)]
        public int? ReportDays { get; set; }

        /// <summary>
        /// The end date on which the report is sent. The value is in the yyyy-MM-dd format.
        /// 
        /// >  This parameter is required if the ReportType parameter is set to 3.
        /// </summary>
        [NameInMap("ReportEndDate")]
        [Validation(Required=false)]
        public string ReportEndDate { get; set; }

        /// <summary>
        /// The ID of the report.
        /// 
        /// >  You can call the [DescribeCustomizeReportList](~~DescribeCustomizeReportList~~) operation to query the ID.
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
        public int? ReportSendType { get; set; }

        /// <summary>
        /// The start date on which the report is sent. The value is in the yyyy-MM-dd format.
        /// 
        /// >  This parameter is required if the ReportType parameter is set to 3.
        /// </summary>
        [NameInMap("ReportStartDate")]
        [Validation(Required=false)]
        public string ReportStartDate { get; set; }

        /// <summary>
        /// The status of the report. Valid values:
        /// 
        /// *   **0**: disabled.
        /// *   **1**: enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public int? ReportStatus { get; set; }

        /// <summary>
        /// The type of the report. Valid values:
        /// 
        /// *   **0**: daily report.
        /// *   **1**: weekly report.
        /// *   **2**: monthly report.
        /// *   **3**: report whose statistics are collected within a custom time range.
        /// *   **4**: report of the most recent time range.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public int? ReportType { get; set; }

        /// <summary>
        /// The version of the report. Valid values:
        /// 
        /// *   **1.0.0**
        /// *   **2.0.0**
        /// </summary>
        [NameInMap("ReportVersion")]
        [Validation(Required=false)]
        public string ReportVersion { get; set; }

        /// <summary>
        /// The end time at which the report is sent. The value is in the HH:mm:ss format.
        /// 
        /// >  This parameter is required if the ReportType parameter is set to 0, 1, 2, or 4.
        /// </summary>
        [NameInMap("SendEndTime")]
        [Validation(Required=false)]
        public string SendEndTime { get; set; }

        /// <summary>
        /// The exact day within the sending period.
        /// 
        /// >  This parameter is supported only in version 2.0.0.
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
        /// 
        /// >  This parameter is supported only in version 2.0.0.
        /// </summary>
        [NameInMap("SendPeriodType")]
        [Validation(Required=false)]
        public string SendPeriodType { get; set; }

        /// <summary>
        /// The start time at which the report is sent. The value is in the HH:mm:ss format.
        /// 
        /// >  This parameter is required if the ReportType parameter is set to 0, 1, 2, or 4.
        /// </summary>
        [NameInMap("SendStartTime")]
        [Validation(Required=false)]
        public string SendStartTime { get; set; }

        /// <summary>
        /// The groups.
        /// 
        /// >  This parameter is supported only in version 2.0.0.
        /// </summary>
        [NameInMap("TargetGroups")]
        [Validation(Required=false)]
        public string TargetGroups { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account. Separate multiple IDs with commas (,).
        /// 
        /// >  This parameter is supported only in version 2.0.0.
        /// </summary>
        [NameInMap("TargetUids")]
        [Validation(Required=false)]
        public string TargetUids { get; set; }

        /// <summary>
        /// The title of the report.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
