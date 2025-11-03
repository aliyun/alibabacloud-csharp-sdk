// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveCustomizeReportConfigRequest : TeaModel {
        /// <summary>
        /// <para>The grouping type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN_RG</b></description></item>
        /// <item><description><b>SAS_GROUP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SAS_GROUP</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>Whether the new account is connected by default. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes. </description></item>
        /// <item><description><b>false</b>: No. <remarks>
        /// <para>Only supported in version 2.0.0.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MemberAccountSyncFlag")]
        [Validation(Required=false)]
        public bool? MemberAccountSyncFlag { get; set; }

        /// <summary>
        /// <para>The time when the report is pinned. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1717430400000</para>
        /// </summary>
        [NameInMap("PinnedTime")]
        [Validation(Required=false)]
        public long? PinnedTime { get; set; }

        /// <summary>
        /// <para>The email address of the recipient. Separate multiple email addresses with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@163.com">xxx@163.com</a></para>
        /// </summary>
        [NameInMap("Recipients")]
        [Validation(Required=false)]
        public string Recipients { get; set; }

        /// <summary>
        /// <para>The most recent days for report statistics.</para>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ReportDays")]
        [Validation(Required=false)]
        public int? ReportDays { get; set; }

        /// <summary>
        /// <para>The end date on which the report is sent. The value is in the yyyy-MM-dd format.</para>
        /// <remarks>
        /// <para> This parameter is required if the ReportType parameter is set to 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-15</para>
        /// </summary>
        [NameInMap("ReportEndDate")]
        [Validation(Required=false)]
        public string ReportEndDate { get; set; }

        /// <summary>
        /// <para>The ID of the report.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCustomizeReportList~~">DescribeCustomizeReportList</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The language of the report. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("ReportLang")]
        [Validation(Required=false)]
        public string ReportLang { get; set; }

        /// <summary>
        /// <para>The time range in which the report is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: 00:00 to 06:00.</description></item>
        /// <item><description><b>2</b>: 06:00 to 12:00.</description></item>
        /// <item><description><b>3</b>: 12:00 to 18:00.</description></item>
        /// <item><description><b>4</b>: 18:00 to 24:00.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReportSendType")]
        [Validation(Required=false)]
        public int? ReportSendType { get; set; }

        /// <summary>
        /// <para>The start date on which the report is sent. The value is in the yyyy-MM-dd format.</para>
        /// <remarks>
        /// <para> This parameter is required if the ReportType parameter is set to 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01</para>
        /// </summary>
        [NameInMap("ReportStartDate")]
        [Validation(Required=false)]
        public string ReportStartDate { get; set; }

        /// <summary>
        /// <para>The status of the report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public int? ReportStatus { get; set; }

        /// <summary>
        /// <para>The type of the report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: daily report.</description></item>
        /// <item><description><b>1</b>: weekly report.</description></item>
        /// <item><description><b>2</b>: monthly report.</description></item>
        /// <item><description><b>3</b>: report whose statistics are collected within a custom time range.</description></item>
        /// <item><description><b>4</b>: report of the most recent time range.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public int? ReportType { get; set; }

        /// <summary>
        /// <para>The version of the report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b></description></item>
        /// <item><description><b>2.0.0</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("ReportVersion")]
        [Validation(Required=false)]
        public string ReportVersion { get; set; }

        /// <summary>
        /// <para>The end time at which the report is sent. The value is in the HH:mm:ss format.</para>
        /// <remarks>
        /// <para> This parameter is required if the ReportType parameter is set to 0, 1, 2, or 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10:00:00</para>
        /// </summary>
        [NameInMap("SendEndTime")]
        [Validation(Required=false)]
        public string SendEndTime { get; set; }

        /// <summary>
        /// <para>The exact day within the sending period.</para>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("SendPeriodDays")]
        [Validation(Required=false)]
        public int? SendPeriodDays { get; set; }

        /// <summary>
        /// <para>The interval at which the report is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DAY</b></description></item>
        /// <item><description><b>WEEK</b></description></item>
        /// <item><description><b>MONTH</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MONTH</para>
        /// </summary>
        [NameInMap("SendPeriodType")]
        [Validation(Required=false)]
        public string SendPeriodType { get; set; }

        /// <summary>
        /// <para>The start time at which the report is sent. The value is in the HH:mm:ss format.</para>
        /// <remarks>
        /// <para> This parameter is required if the ReportType parameter is set to 0, 1, 2, or 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>09:00:00</para>
        /// </summary>
        [NameInMap("SendStartTime")]
        [Validation(Required=false)]
        public string SendStartTime { get; set; }

        /// <summary>
        /// <para>The groups.</para>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12,123</para>
        /// </summary>
        [NameInMap("TargetGroups")]
        [Validation(Required=false)]
        public string TargetGroups { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter is supported only in version 2.0.0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12,123</para>
        /// </summary>
        [NameInMap("TargetUids")]
        [Validation(Required=false)]
        public string TargetUids { get; set; }

        /// <summary>
        /// <para>The title of the report.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily Report</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
