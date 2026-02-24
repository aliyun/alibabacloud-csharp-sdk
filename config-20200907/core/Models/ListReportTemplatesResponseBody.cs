// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListReportTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 1 to 50. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>If the response is truncated, use NextToken to send another request and get results after the truncation point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aVCjqNaSy0Ps7zSMGu25****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of report templates.</para>
        /// </summary>
        [NameInMap("ReportTemplateList")]
        [Validation(Required=false)]
        public List<ListReportTemplatesResponseBodyReportTemplateList> ReportTemplateList { get; set; }
        public class ListReportTemplatesResponseBodyReportTemplateList : TeaModel {
            /// <summary>
            /// <para>The format of the report. Only Excel is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>excel</para>
            /// </summary>
            [NameInMap("ReportFileFormats")]
            [Validation(Required=false)]
            public string ReportFileFormats { get; set; }

            /// <summary>
            /// <para>The aggregation granularity of the report.</para>
            /// <para>From the management account perspective, the following options are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>AllInOne: Aggregate all accounts in the template scope into one report.</para>
            /// </description></item>
            /// <item><description><para>GroupByAggregator: Generate reports by aggregator group. Output as one compressed file.</para>
            /// </description></item>
            /// <item><description><para>GroupByAccount: Generate separate reports for each account (default). Output as one compressed file.</para>
            /// </description></item>
            /// </list>
            /// <para>Member accounts support only GroupByAccount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AllInOne</para>
            /// </summary>
            [NameInMap("ReportGranularity")]
            [Validation(Required=false)]
            public string ReportGranularity { get; set; }

            /// <summary>
            /// <para>The language of the report. Valid values: zh-CN and en-US. Default value: en-US.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en-US</para>
            /// </summary>
            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

            /// <summary>
            /// <para>An array that defines which rules appear in the audit report. Each ReportScope object uses OR logic (additive logic).</para>
            /// <remarks>
            /// <para>For example, if the array has two items — the first specifies RuleId cr-1 and the second specifies RuleId cr-2 — then the report covers both cr-1 and cr-2.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ReportScope")]
            [Validation(Required=false)]
            public List<ListReportTemplatesResponseBodyReportTemplateListReportScope> ReportScope { get; set; }
            public class ListReportTemplatesResponseBodyReportTemplateListReportScope : TeaModel {
                /// <summary>
                /// <para>The key for the report scope. Supported values:</para>
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
                /// <para>The value for the report scope. For multiple values of the same type — such as multiple rule IDs — separate them with commas (,).</para>
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
            /// <para>The subscription frequency of the report. If this parameter is specified, it must be a Quartz-formatted cron expression.</para>
            /// <para>The format is: second minute hour day month weekday. Common examples:</para>
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
            /// <item><description><para>&quot;?&quot; means no specific value for day or weekday.</para>
            /// </description></item>
            /// <item><description><para>&quot;MON&quot; means Monday.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Times are in UTC+8. Adjust your cron expression based on your local time zone.</para>
            /// </remarks>
            /// <remarks>
            /// <para>The system tries to run reports at the scheduled time, but delays may occur due to report generation. Each template can trigger at most one notification per day.</para>
            /// </remarks>
            /// <remarks>
            /// <para>In Quartz, weekdays are numbered starting from Sunday: 1 = Sunday, 2 = Monday, 3 = Tuesday, 4 = Wednesday, 5 = Thursday, 6 = Friday, 7 = Saturday.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 13 * * ?</para>
            /// </summary>
            [NameInMap("SubscriptionFrequency")]
            [Validation(Required=false)]
            public string SubscriptionFrequency { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8195B664-9565-4685-89AC-8B5F04B44B92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
