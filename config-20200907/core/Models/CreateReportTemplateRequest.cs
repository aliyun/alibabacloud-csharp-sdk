// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateReportTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Report format. Currently, only Excel is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("ReportFileFormats")]
        [Validation(Required=false)]
        public string ReportFileFormats { get; set; }

        /// <summary>
        /// <para>Report aggregation granularity.</para>
        /// <para>Supported for management accounts:</para>
        /// <list type="bullet">
        /// <item><description><para>AllInOne (All accounts within the template scope are aggregated into one report)</para>
        /// </description></item>
        /// <item><description><para>GroupByAggregator (Reports are aggregated by account group, generating a compressed file)</para>
        /// </description></item>
        /// <item><description><para>GroupByAccount (Each account generates a separate report (default), generating a compressed file)</para>
        /// </description></item>
        /// </list>
        /// <para>Member accounts only support GroupByAccount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GroupByAccount</para>
        /// </summary>
        [NameInMap("ReportGranularity")]
        [Validation(Required=false)]
        public string ReportGranularity { get; set; }

        /// <summary>
        /// <para>Report language. Supports zh-CN and en-US. If empty, the default is en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>An array of report scopes, used to select the range of rules included in the audit report. The logic between each ReportScope in the array is OR, which means additive logic.</para>
        /// <remarks>
        /// <para>For example, if the array size is 2, the first ReportScope specifies rule In cr-1, and the second ReportScope specifies rule In cr-2, then the rule scope defined by this report is cr-1 and cr-2.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ReportScope")]
        [Validation(Required=false)]
        public List<CreateReportTemplateRequestReportScope> ReportScope { get; set; }
        public class CreateReportTemplateRequestReportScope : TeaModel {
            /// <summary>
            /// <para>The key for the report scope. Currently supports:</para>
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
            /// <para>Matching logic. Currently, only In is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>In</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The value for the report scope. Multiple items of the same type, such as multiple Rule IDs, can be separated by English commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-1,cr-2</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Report template description</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-report-description</para>
        /// </summary>
        [NameInMap("ReportTemplateDescription")]
        [Validation(Required=false)]
        public string ReportTemplateDescription { get; set; }

        /// <summary>
        /// <para>Report template name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-report-name</para>
        /// </summary>
        [NameInMap("ReportTemplateName")]
        [Validation(Required=false)]
        public string ReportTemplateName { get; set; }

        /// <summary>
        /// <para>Report subscription frequency. If this field is not empty, it is a Quartz-format Cron expression that triggers subscription notifications.</para>
        /// <para>Format: second minute hour day month week. The following are common Cron expression examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Execute at 0:00 every day: 0 0 0 \* \* ?</para>
        /// </description></item>
        /// <item><description><para>Execute at 15:30 every Monday: 0 30 15 ? \* MON</para>
        /// </description></item>
        /// <item><description><para>Execute at 2:00 on the 1st of every month: 0 0 2 1 \* ?</para>
        /// </description></item>
        /// </list>
        /// <para>Where:</para>
        /// <list type="bullet">
        /// <item><description><para>&quot;\*&quot; indicates any value</para>
        /// </description></item>
        /// <item><description><para>&quot;?&quot; is used for day and week fields, indicating no specific value</para>
        /// </description></item>
        /// <item><description><para>&quot;MON&quot; indicates Monday</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The trigger time is UTC+8. Adjust the Cron expression settings based on your time zone.</para>
        /// </remarks>
        /// <remarks>
        /// <para>We try to trigger notifications according to the Cron expression time, but there might be delays due to report generation status. A Cron expression limits the same template to trigger notifications at most once per day.</para>
        /// </remarks>
        /// <remarks>
        /// <para>1 represents Sunday; 2 represents Monday; 3 represents Tuesday; 4 represents Wednesday; 5 represents Thursday; 6 represents Friday; 7 represents Saturday</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 9 * * ?</para>
        /// </summary>
        [NameInMap("SubscriptionFrequency")]
        [Validation(Required=false)]
        public string SubscriptionFrequency { get; set; }

    }

}
