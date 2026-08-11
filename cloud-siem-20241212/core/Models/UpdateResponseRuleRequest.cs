// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateResponseRuleRequest : TeaModel {
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
        /// <para>The pagination token that marks the position from which to start reading. If this parameter is left empty, data is read from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region where the data management center of the threat analysis feature is located. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The action configuration of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;actionType&quot;:&quot;doPlaybook&quot;,&quot;playbookName&quot;:&quot;block waf IP&quot;,&quot;playbookUuid&quot;:&quot;system_aliyun_waf_whole_process_book&quot;,&quot;disposeParam&quot;:{&quot;period&quot;:&quot;7d&quot;}}]</para>
        /// </summary>
        [NameInMap("ResponseActionConfig")]
        [Validation(Required=false)]
        public string ResponseActionConfig { get; set; }

        /// <summary>
        /// <para>The action type of the automated response rule. Valid values:</para>
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
        /// <para>alertWhitelist</para>
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
        /// <para>The ID of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>440918</para>
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
        /// <para>The execution priority of the automated response rule.</para>
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
        /// <para>The status of the automated response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disabled.</description></item>
        /// <item><description>100: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResponseRuleStatus")]
        [Validation(Required=false)]
        public int? ResponseRuleStatus { get; set; }

        /// <summary>
        /// <para>The trigger type of the automated response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>event: event occurred.</description></item>
        /// <item><description>event_update: event updated.</description></item>
        /// <item><description>alert: alert occurred.</description></item>
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
