// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizeReportConfigDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The report chart configuration IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIZ_STAT_QUERY_KEY_ATTACK,CUSTOM_VUL_CVE_LIST,CUSTOM_VUL_SYS_LIST,CUSTOM_VUL_WEBCMS_LIST,CUSTOM_AUTO_BREAKING_PIE,CUSTOM_AK_LEAK_LIST,KEY_HP_TAMPERPROOF,KEY_HP_DEFENCE</para>
        /// </summary>
        [NameInMap("ChartIds")]
        [Validation(Required=false)]
        public string ChartIds { get; set; }

        /// <summary>
        /// <para>The group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN_RG</b>: ALIYUN_RG.</description></item>
        /// <item><description><b>SAS_GROUP</b>: SAS_GROUP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SAS_GROUP</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>Indicates whether the report is a default report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not a default report.</description></item>
        /// <item><description><b>1</b>: A default report.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public int? IsDefault { get; set; }

        /// <summary>
        /// <para>Specifies whether newly added accounts are included by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Included.</description></item>
        /// <item><description><b>false</b>: Not included.<remarks>
        /// <para>Only version 2.0.0 supports this parameter.</para>
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
        /// <para>The pinned time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717430400000</para>
        /// </summary>
        [NameInMap("PinnedTime")]
        [Validation(Required=false)]
        public long? PinnedTime { get; set; }

        /// <summary>
        /// <para>The recipient email addresses, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:PengZheng@eaton.com">PengZheng@eaton.com</a>,<a href="mailto:ZhongJi@Eaton.com">ZhongJi@Eaton.com</a></para>
        /// </summary>
        [NameInMap("Recipients")]
        [Validation(Required=false)]
        public string Recipients { get; set; }

        /// <summary>
        /// <para>The number of recent days covered by the report statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ReportDays")]
        [Validation(Required=false)]
        public int? ReportDays { get; set; }

        /// <summary>
        /// <para>The end date for report delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1720022399999</para>
        /// </summary>
        [NameInMap("ReportEndDate")]
        [Validation(Required=false)]
        public string ReportEndDate { get; set; }

        /// <summary>
        /// <para>The report ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>663434</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The language type. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("ReportLang")]
        [Validation(Required=false)]
        public string ReportLang { get; set; }

        /// <summary>
        /// <para>The report delivery time range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: 0:00 to 6:00.</description></item>
        /// <item><description><b>2</b>: 6:00 to 12:00.</description></item>
        /// <item><description><b>3</b>: 12:00 to 18:00.</description></item>
        /// <item><description><b>4</b>: 18:00 to 24:00.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReportSendType")]
        [Validation(Required=false)]
        public string ReportSendType { get; set; }

        /// <summary>
        /// <para>The start date for report delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717430400000</para>
        /// </summary>
        [NameInMap("ReportStartDate")]
        [Validation(Required=false)]
        public string ReportStartDate { get; set; }

        /// <summary>
        /// <para>The report status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public string ReportStatus { get; set; }

        /// <summary>
        /// <para>The report type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Daily report.</description></item>
        /// <item><description><b>1</b>: Weekly report.</description></item>
        /// <item><description><b>2</b>: Monthly report.</description></item>
        /// <item><description><b>3</b>: Custom period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>379a9b8f-107b-4630-9e95-2299a1ea****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The delivery end time, in the format of HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10:00:00</para>
        /// </summary>
        [NameInMap("SendEndTime")]
        [Validation(Required=false)]
        public string SendEndTime { get; set; }

        /// <summary>
        /// <para>The specific execution dates within the delivery period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("SendPeriodDays")]
        [Validation(Required=false)]
        public int? SendPeriodDays { get; set; }

        /// <summary>
        /// <para>The delivery period type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DAY</b>: day.</description></item>
        /// <item><description><b>WEEK</b>: week.</description></item>
        /// <item><description><b>MONTH</b>: month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MONTH</para>
        /// </summary>
        [NameInMap("SendPeriodType")]
        [Validation(Required=false)]
        public string SendPeriodType { get; set; }

        /// <summary>
        /// <para>The delivery start time, in the format of HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00:00</para>
        /// </summary>
        [NameInMap("SendStartTime")]
        [Validation(Required=false)]
        public string SendStartTime { get; set; }

        /// <summary>
        /// <para>The delivery time, in the format of HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00:00</para>
        /// </summary>
        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public string SendTime { get; set; }

        /// <summary>
        /// <para>The targets within the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12125884,12140191</para>
        /// </summary>
        [NameInMap("TargetGroups")]
        [Validation(Required=false)]
        public string TargetGroups { get; set; }

        /// <summary>
        /// <para>The list of target UIDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1457515594445744,1600011353839072,1766185894104675,1674080148055995,1627510829033157</para>
        /// </summary>
        [NameInMap("TargetUids")]
        [Validation(Required=false)]
        public string TargetUids { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>marketing report</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
