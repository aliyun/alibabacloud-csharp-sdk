// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateReportTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The format of the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("ReportFileFormats")]
        [Validation(Required=false)]
        public string ReportFileFormats { get; set; }

        /// <summary>
        /// <para>The aggregation granularity of the report.</para>
        /// <para>For a management account, the following values are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>AllInOne: A single report is generated for all accounts within the template scope.</para>
        /// </description></item>
        /// <item><description><para>GroupByAggregator: Reports are aggregated by account group. A compressed file is generated.</para>
        /// </description></item>
        /// <item><description><para>GroupByAccount: A separate report is generated for each account. This is the default value. A compressed file is generated.</para>
        /// </description></item>
        /// </list>
        /// <para>For a member account, only GroupByAccount is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllInOne</para>
        /// </summary>
        [NameInMap("ReportGranularity")]
        [Validation(Required=false)]
        public string ReportGranularity { get; set; }

        /// <summary>
        /// <para>The language of the report. Valid values: zh-CN and en-US. If you leave this parameter empty, the default value en-US is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>An array that specifies the report scope. It is used to select the range of rules to include in the audit report. The logical relationship between multiple ReportScope objects in the array is OR. This means the scopes are added together.</para>
        /// <remarks>
        /// <para>For example, if the array contains two ReportScope objects, where the first specifies the rule In cr-1 and the second specifies the rule In cr-2, the report scope includes both cr-1 and cr-2.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ReportScope")]
        [Validation(Required=false)]
        public List<UpdateReportTemplateRequestReportScope> ReportScope { get; set; }
        public class UpdateReportTemplateRequestReportScope : TeaModel {
            /// <summary>
            /// <para>The key of the report scope. Supported values:</para>
            /// <list type="bullet">
            /// <item><description><para>AggregatorId</para>
            /// </description></item>
            /// <item><description><para>CompliancePackId</para>
            /// </description></item>
            /// <item><description><para>RuleId</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RuleId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching logic. Only In is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>In</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The value of the report scope. To specify multiple items of the same type, such as multiple rule IDs, separate them with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-1,cr-2</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the report template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-description</para>
        /// </summary>
        [NameInMap("ReportTemplateDescription")]
        [Validation(Required=false)]
        public string ReportTemplateDescription { get; set; }

        /// <summary>
        /// <para>The ID of the report template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crt-xxx</para>
        /// </summary>
        [NameInMap("ReportTemplateId")]
        [Validation(Required=false)]
        public string ReportTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the report template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-name</para>
        /// </summary>
        [NameInMap("ReportTemplateName")]
        [Validation(Required=false)]
        public string ReportTemplateName { get; set; }

        /// <summary>
        /// <para>The frequency for subscribing to the report. If this parameter is not empty, it specifies a cron expression in the Quartz format that triggers a subscription notification.</para>
        /// <para>The format is: Second Minute Hour Day Month Week. The following list provides common examples of cron expressions:</para>
        /// <list type="bullet">
        /// <item><description><para>To run at 00:00 every day: 0 0 0 \* \* ?</para>
        /// </description></item>
        /// <item><description><para>To run at 15:30 every Monday: 0 30 15 ? \* MON</para>
        /// </description></item>
        /// <item><description><para>To run at 02:00 on the first day of every month: 0 0 2 1 \* ?</para>
        /// </description></item>
        /// </list>
        /// <para>Where:</para>
        /// <list type="bullet">
        /// <item><description><para>&quot;\*&quot; indicates any value.</para>
        /// </description></item>
        /// <item><description><para>? is used in the Day and Week fields and indicates that no specific value is specified.</para>
        /// </description></item>
        /// <item><description><para>MON indicates Monday.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The trigger time is in UTC+8. You can convert the cron expression based on your time zone.</para>
        /// </remarks>
        /// <remarks>
        /// <para>The system attempts to trigger the notification at the time specified by the cron expression. However, a delay may occur due to the report generation status. The cron expression limits the notification for the same template to a maximum of once per day.</para>
        /// </remarks>
        /// <remarks>
        /// <para>In addition to using MON for Monday, you can also use numbers. In the Quartz framework, 1 represents Sunday, 2 represents Monday, 3 represents Tuesday, 4 represents Wednesday, 5 represents Thursday, 6 represents Friday, and 7 represents Saturday.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 0 * * ?</para>
        /// </summary>
        [NameInMap("SubscriptionFrequency")]
        [Validation(Required=false)]
        public string SubscriptionFrequency { get; set; }

    }

}
