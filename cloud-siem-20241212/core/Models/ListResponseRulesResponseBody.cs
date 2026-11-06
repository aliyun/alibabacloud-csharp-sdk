// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListResponseRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position to which the current call has read. An empty value indicates that all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASLVeIxed4466E0LVmGkzwS6hJKd9DGVGMDRM6Lu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of automatic response rules.</para>
        /// </summary>
        [NameInMap("ResponseRules")]
        [Validation(Required=false)]
        public List<ListResponseRulesResponseBodyResponseRules> ResponseRules { get; set; }
        public class ListResponseRulesResponseBodyResponseRules : TeaModel {
            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1769843323000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The action configuration of the automatic response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;actionType&quot;:&quot;doPlaybook&quot;,&quot;playbookName&quot;:&quot;block waf IP&quot;,&quot;playbookUuid&quot;:&quot;system_aliyun_waf_whole_process_book&quot;,&quot;disposeParam&quot;:{&quot;period&quot;:&quot;7d&quot;}}]</para>
            /// </summary>
            [NameInMap("ResponseActionConfig")]
            [Validation(Required=false)]
            public string ResponseActionConfig { get; set; }

            /// <summary>
            /// <para>The action type of the automatic response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>doPlaybook: Execute a playbook.</description></item>
            /// <item><description>changeEventStatus: Update the event status.</description></item>
            /// <item><description>changeThreatLevel: Update the event threat level.</description></item>
            /// <item><description>addEventTag: Add an event tag.</description></item>
            /// <item><description>deleteEventTag: Delete an event tag.</description></item>
            /// <item><description>alertWhitelist: Add an alert to the whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>doPlaybook</para>
            /// </summary>
            [NameInMap("ResponseActionType")]
            [Validation(Required=false)]
            public string ResponseActionType { get; set; }

            /// <summary>
            /// <para>The trigger condition configuration of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;left&quot;:{&quot;value&quot;:&quot;threat_level&quot;},&quot;operator&quot;:&quot;equals&quot;,&quot;right&quot;:{&quot;value&quot;:&quot;suspicious&quot;}}]</para>
            /// </summary>
            [NameInMap("ResponseExecutionCondition")]
            [Validation(Required=false)]
            public string ResponseExecutionCondition { get; set; }

            /// <summary>
            /// <para>The ID of the automatic response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403235</para>
            /// </summary>
            [NameInMap("ResponseRuleId")]
            [Validation(Required=false)]
            public string ResponseRuleId { get; set; }

            /// <summary>
            /// <para>The name of the automatic response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Send Notification When Generating Urgent Incident</para>
            /// </summary>
            [NameInMap("ResponseRuleName")]
            [Validation(Required=false)]
            public string ResponseRuleName { get; set; }

            /// <summary>
            /// <para>The execution priority of the automatic response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResponseRulePriority")]
            [Validation(Required=false)]
            public int? ResponseRulePriority { get; set; }

            /// <summary>
            /// <para>The remarks of the response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Send a notification when Security Center detects high-risk or critical malicious process (cloud antivirus) alerts. Only notify, do not take action</para>
            /// </summary>
            [NameInMap("ResponseRuleRemark")]
            [Validation(Required=false)]
            public string ResponseRuleRemark { get; set; }

            /// <summary>
            /// <para>The status of the automatic response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>100: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResponseRuleStatus")]
            [Validation(Required=false)]
            public int? ResponseRuleStatus { get; set; }

            /// <summary>
            /// <para>The type of the response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>preset: Preset.</description></item>
            /// <item><description>custom: Custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ResponseRuleType")]
            [Validation(Required=false)]
            public string ResponseRuleType { get; set; }

            /// <summary>
            /// <para>The trigger type of the automatic response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>event: Event occurrence.</description></item>
            /// <item><description>event_update: Event update.</description></item>
            /// <item><description>alert: Alert occurrence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>event</para>
            /// </summary>
            [NameInMap("ResponseTriggerType")]
            [Validation(Required=false)]
            public string ResponseTriggerType { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1769843323000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of data records that meet the request conditions. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
