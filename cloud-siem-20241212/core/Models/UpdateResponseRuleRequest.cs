// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateResponseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If you do not specify this parameter, the query starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Cloud SIEM is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cn-hangzhou</c>: China (Hangzhou). For assets in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><c>ap-southeast-1</c>: Asia Pacific SE 1 (Singapore). For assets in overseas regions.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The action configuration for the automatic response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;actionType&quot;:&quot;doPlaybook&quot;,&quot;playbookName&quot;:&quot;block waf IP&quot;,&quot;playbookUuid&quot;:&quot;system_aliyun_waf_whole_process_book&quot;,&quot;disposeParam&quot;:{&quot;period&quot;:&quot;7d&quot;}}]</para>
        /// </summary>
        [NameInMap("ResponseActionConfig")]
        [Validation(Required=false)]
        public string ResponseActionConfig { get; set; }

        /// <summary>
        /// <para>The action for the automatic response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>doPlaybook</c>: Executes a playbook.</para>
        /// </description></item>
        /// <item><description><para><c>changeEventStatus</c>: Updates the event status.</para>
        /// </description></item>
        /// <item><description><para><c>changeThreatLevel</c>: Updates the event threat level.</para>
        /// </description></item>
        /// <item><description><para><c>addEventTag</c>: Adds an event tag.</para>
        /// </description></item>
        /// <item><description><para><c>deleteEventTag</c>: Deletes an event tag.</para>
        /// </description></item>
        /// <item><description><para><c>alertWhitelist</c>: Adds the alert to a whitelist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alertWhitelist</para>
        /// </summary>
        [NameInMap("ResponseActionType")]
        [Validation(Required=false)]
        public string ResponseActionType { get; set; }

        /// <summary>
        /// <para>The trigger conditions for the rule.</para>
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
        /// <para>440918</para>
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
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: disabled</para>
        /// </description></item>
        /// <item><description><para><c>100</c>: enabled</para>
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
        /// <para>The trigger for the automatic response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>event</c>: The rule is triggered when an event occurs.</para>
        /// </description></item>
        /// <item><description><para><c>event_update</c>: The rule is triggered when an event is updated.</para>
        /// </description></item>
        /// <item><description><para><c>alert</c>: The rule is triggered when an alert is generated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("ResponseTriggerType")]
        [Validation(Required=false)]
        public string ResponseTriggerType { get; set; }

    }

}
