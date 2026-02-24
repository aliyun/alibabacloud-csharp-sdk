// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetReportTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>Report template.</para>
        /// </summary>
        [NameInMap("ReportTemplate")]
        [Validation(Required=false)]
        public GetReportTemplateResponseBodyReportTemplate ReportTemplate { get; set; }
        public class GetReportTemplateResponseBodyReportTemplate : TeaModel {
            /// <summary>
            /// <para>Report file format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>excel</para>
            /// </summary>
            [NameInMap("ReportFileFormats")]
            [Validation(Required=false)]
            public string ReportFileFormats { get; set; }

            /// <summary>
            /// <para>Aggregation granularity of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AllInOne</para>
            /// </summary>
            [NameInMap("ReportGranularity")]
            [Validation(Required=false)]
            public string ReportGranularity { get; set; }

            /// <summary>
            /// <para>Report language. Valid values: zh-CN and en-US. Default is en-US if empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en-US</para>
            /// </summary>
            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

            /// <summary>
            /// <para>Array of report scopes. Each scope defines a set of rules included in the audit report. Scopes use OR logic. That is, rules from all scopes are combined.</para>
            /// <remarks>
            /// <para>If the array has two items, and the first specifies RuleId cr-1 while the second specifies RuleId cr-2, then the report covers both cr-1 and cr-2.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ReportScope")]
            [Validation(Required=false)]
            public List<GetReportTemplateResponseBodyReportTemplateReportScope> ReportScope { get; set; }
            public class GetReportTemplateResponseBodyReportTemplateReportScope : TeaModel {
                /// <summary>
                /// <para>Key for the report scope. Supported keys:</para>
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
                /// <para>Matching logic. Only In is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>In</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>Value for the report scope. For multiple values of the same type, such as multiple rule IDs, separate them with commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-1,cr-2</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Description of the report template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-description</para>
            /// </summary>
            [NameInMap("ReportTemplateDescription")]
            [Validation(Required=false)]
            public string ReportTemplateDescription { get; set; }

            /// <summary>
            /// <para>ID of the report template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crt-xxx</para>
            /// </summary>
            [NameInMap("ReportTemplateId")]
            [Validation(Required=false)]
            public string ReportTemplateId { get; set; }

            /// <summary>
            /// <para>Name of the report template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("ReportTemplateName")]
            [Validation(Required=false)]
            public string ReportTemplateName { get; set; }

            /// <summary>
            /// <para>Subscription frequency for the report. If this field is not empty, it contains a Quartz-formatted cron expression that triggers notifications.</para>
            /// <para>The format is: seconds minutes hours day-of-month month day-of-week. Common examples include the following:</para>
            /// <list type="bullet">
            /// <item><description><para>Run daily at 00:00: 0 0 0 \* \* ?</para>
            /// </description></item>
            /// <item><description><para>Run every Monday at 15:30: 0 30 15 ? \* MON</para>
            /// </description></item>
            /// <item><description><para>Run on the first day of each month at 02:00: 0 0 2 1 \* ?</para>
            /// </description></item>
            /// </list>
            /// <para>Where:</para>
            /// <list type="bullet">
            /// <item><description><para>&quot;\*&quot; means any value.</para>
            /// </description></item>
            /// <item><description><para>&quot;?&quot; means no specific value for the day-of-month or day-of-week field.</para>
            /// </description></item>
            /// <item><description><para>MON means Monday.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Trigger times are in UTC+8. Adjust your cron expression based on your time zone.</para>
            /// </remarks>
            /// <remarks>
            /// <para>The system tries to trigger notifications as close as possible to the scheduled time. Delays may occur due to report generation status. A single template can trigger at most one notification per day.</para>
            /// </remarks>
            /// <remarks>
            /// <para>In Quartz, days of the week are numbered: 1 = Sunday, 2 = Monday, 3 = Tuesday, 4 = Wednesday, 5 = Thursday, 6 = Friday, 7 = Saturday.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 0 * * ?</para>
            /// </summary>
            [NameInMap("SubscriptionFrequency")]
            [Validation(Required=false)]
            public string SubscriptionFrequency { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7A0FFF8-0B44-40C6-8BBF-3A185EFDF3F7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
