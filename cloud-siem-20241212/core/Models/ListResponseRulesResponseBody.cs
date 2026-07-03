// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListResponseRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position where the current query ends. If this parameter is empty, all data is returned.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of automated response rules.</para>
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
            /// <para>The configuration of the action that is performed if the automated response rule is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;actionType&quot;:&quot;doPlaybook&quot;,&quot;playbookName&quot;:&quot;block waf IP&quot;,&quot;playbookUuid&quot;:&quot;system_aliyun_waf_whole_process_book&quot;,&quot;disposeParam&quot;:{&quot;period&quot;:&quot;7d&quot;}}]</para>
            /// </summary>
            [NameInMap("ResponseActionConfig")]
            [Validation(Required=false)]
            public string ResponseActionConfig { get; set; }

            /// <summary>
            /// <para>The type of the action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>doPlaybook</c>: executes a playbook.</para>
            /// </description></item>
            /// <item><description><para><c>changeEventStatus</c>: changes the status of an event.</para>
            /// </description></item>
            /// <item><description><para><c>changeThreatLevel</c>: changes the threat level of an event.</para>
            /// </description></item>
            /// <item><description><para><c>addEventTag</c>: adds a tag to an event.</para>
            /// </description></item>
            /// <item><description><para><c>deleteEventTag</c>: removes a tag from an event.</para>
            /// </description></item>
            /// <item><description><para><c>alertWhitelist</c>: adds an alert to the whitelist.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>doPlaybook</para>
            /// </summary>
            [NameInMap("ResponseActionType")]
            [Validation(Required=false)]
            public string ResponseActionType { get; set; }

            /// <summary>
            /// <para>The trigger condition of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;left&quot;:{&quot;value&quot;:&quot;threat_level&quot;},&quot;operator&quot;:&quot;equals&quot;,&quot;right&quot;:{&quot;value&quot;:&quot;suspicious&quot;}}]</para>
            /// </summary>
            [NameInMap("ResponseExecutionCondition")]
            [Validation(Required=false)]
            public string ResponseExecutionCondition { get; set; }

            /// <summary>
            /// <para>The ID of the automated response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403235</para>
            /// </summary>
            [NameInMap("ResponseRuleId")]
            [Validation(Required=false)]
            public string ResponseRuleId { get; set; }

            /// <summary>
            /// <para>The name of the automated response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Send Notification When Generating Urgent Incident</para>
            /// </summary>
            [NameInMap("ResponseRuleName")]
            [Validation(Required=false)]
            public string ResponseRuleName { get; set; }

            /// <summary>
            /// <para>The priority of the automated response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResponseRulePriority")]
            [Validation(Required=false)]
            public int? ResponseRulePriority { get; set; }

            /// <summary>
            /// <para>The status of the automated response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: disabled.</para>
            /// </description></item>
            /// <item><description><para><c>100</c>: enabled.</para>
            /// </description></item>
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
            /// <item><description><para><c>preset</c>: a predefined rule.</para>
            /// </description></item>
            /// <item><description><para><c>custom</c>: a custom rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ResponseRuleType")]
            [Validation(Required=false)]
            public string ResponseRuleType { get; set; }

            /// <summary>
            /// <para>The trigger type of the automated response rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>event</c>: triggered when an event occurs.</para>
            /// </description></item>
            /// <item><description><para><c>event_update</c>: triggered when an event is updated.</para>
            /// </description></item>
            /// <item><description><para><c>alert</c>: triggered when an alert is generated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>event</para>
            /// </summary>
            [NameInMap("ResponseTriggerType")]
            [Validation(Required=false)]
            public string ResponseTriggerType { get; set; }

            /// <summary>
            /// <para>The time when the rule was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1769843323000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that match the query conditions. This parameter is optional and may not always be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
