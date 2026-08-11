// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListResponseRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position from which the current call starts reading. An empty value indicates that all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASLVeIxed4466E0LVmGkzwS6hJKd9DGVGMDRM6Lu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
            /// <para>The time when the rule was created.</para>
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
            /// <item><description>doPlaybook: execute a playbook</description></item>
            /// <item><description>changeEventStatus: update event status</description></item>
            /// <item><description>changeThreatLevel: update event threat level</description></item>
            /// <item><description>addEventTag: add an event label</description></item>
            /// <item><description>deleteEventTag: delete an event label</description></item>
            /// <item><description>alertWhitelist: add alert to whitelist</description></item>
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

            [NameInMap("ResponseRuleRemark")]
            [Validation(Required=false)]
            public string ResponseRuleRemark { get; set; }

            /// <summary>
            /// <para>The status of the automatic response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled</description></item>
            /// <item><description>100: enabled</description></item>
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
            /// <item><description>preset: predefined</description></item>
            /// <item><description>custom: custom</description></item>
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
            /// <item><description>event: event occurred</description></item>
            /// <item><description>event_update: event updated</description></item>
            /// <item><description>alert: alert occurred</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>event</para>
            /// </summary>
            [NameInMap("ResponseTriggerType")]
            [Validation(Required=false)]
            public string ResponseTriggerType { get; set; }

            /// <summary>
            /// <para>The time when the rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1769843323000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of records that match the request conditions. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
