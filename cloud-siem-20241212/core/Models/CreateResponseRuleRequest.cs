// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateResponseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to read in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that marks the current reading position. Leave this parameter empty to start reading from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region where the threat detection and response data management center resides. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <item><description>doPlaybook: execute a playbook.</description></item>
        /// <item><description>changeEventStatus: update the event status.</description></item>
        /// <item><description>changeThreatLevel: update the event threat level.</description></item>
        /// <item><description>addEventTag: add an event label.</description></item>
        /// <item><description>deleteEventTag: delete an event label.</description></item>
        /// <item><description>alertWhitelist: add the alert to the whitelist.</description></item>
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
        public string ResponseRulePriority { get; set; }

        [NameInMap("ResponseRuleRemark")]
        [Validation(Required=false)]
        public string ResponseRuleRemark { get; set; }

        /// <summary>
        /// <para>The trigger type of the automatic response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>event: event occurrence.</description></item>
        /// <item><description>event_update: event update.</description></item>
        /// <item><description>alert: alert occurrence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("ResponseTriggerType")]
        [Validation(Required=false)]
        public string ResponseTriggerType { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator switches to for viewing from the perspective of another member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
