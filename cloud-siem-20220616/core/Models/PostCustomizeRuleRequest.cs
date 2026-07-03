// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The threat type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The Medusa code of the threat type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${siem_rule_type_process_abnormal_command}</para>
        /// </summary>
        [NameInMap("AlertTypeMds")]
        [Validation(Required=false)]
        public string AlertTypeMds { get; set; }

        /// <summary>
        /// <para>The ATT\&amp;CK technique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T1595.002 Vulnerability Scanning</para>
        /// </summary>
        [NameInMap("AttCk")]
        [Validation(Required=false)]
        public string AttCk { get; set; }

        /// <summary>
        /// <para>The extended information for event generation. This parameter is returned only when EventTransferType is set to allToSingle. The value indicates the length and unit of the alert aggregation window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;MINUTE&quot;}</para>
        /// </summary>
        [NameInMap("EventTransferExt")]
        [Validation(Required=false)]
        public string EventTransferExt { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert alerts into events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: no</para>
        /// </description></item>
        /// <item><description><para>1: yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EventTransferSwitch")]
        [Validation(Required=false)]
        public int? EventTransferSwitch { get; set; }

        /// <summary>
        /// <para>The event generation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: the default method</para>
        /// </description></item>
        /// <item><description><para>singleToSingle: An event is generated for each alert.</para>
        /// </description></item>
        /// <item><description><para>allToSingle: An event is generated for all alerts in a period.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>allToSingle</para>
        /// </summary>
        [NameInMap("EventTransferType")]
        [Validation(Required=false)]
        public string EventTransferType { get; set; }

        /// <summary>
        /// <para>The ID of the custom rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The log source of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_aegis_sas_alert</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <para>The Medusa code of the log source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${sas.cloudsiem.prod.cloud_siem_aegis_sas_alert}</para>
        /// </summary>
        [NameInMap("LogSourceMds")]
        [Validation(Required=false)]
        public string LogSourceMds { get; set; }

        /// <summary>
        /// <para>The log type of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The Medusa code of the log type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${security_event_config.event_name.webshellName_clientav}</para>
        /// </summary>
        [NameInMap("LogTypeMds")]
        [Validation(Required=false)]
        public string LogTypeMds { get; set; }

        /// <summary>
        /// <para>The length of the rule window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;HOUR&quot;}</para>
        /// </summary>
        [NameInMap("QueryCycle")]
        [Validation(Required=false)]
        public string QueryCycle { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: assets in the Chinese mainland and China (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: assets outside China</para>
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
        /// <para>The user ID that is used to switch the administrator\&quot;s perspective to a member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that are managed by the administrator.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The query condition of the rule. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[[{&quot;not&quot;:false,&quot;left&quot;:&quot;alert_name&quot;,&quot;operator&quot;:&quot;=&quot;,&quot;right&quot;:&quot;WEBSHELL&quot;}]]</para>
        /// </summary>
        [NameInMap("RuleCondition")]
        [Validation(Required=false)]
        public string RuleCondition { get; set; }

        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this rule is for waf scan</para>
        /// </summary>
        [NameInMap("RuleDesc")]
        [Validation(Required=false)]
        public string RuleDesc { get; set; }

        /// <summary>
        /// <para>The fields that are used to group logs. The value is a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;asset_id&quot;]</para>
        /// </summary>
        [NameInMap("RuleGroup")]
        [Validation(Required=false)]
        public string RuleGroup { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_scan</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The threshold configuration of the rule. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aggregateFunction&quot;:&quot;count&quot;,&quot;aggregateFunctionName&quot;:&quot;count&quot;,&quot;field&quot;:&quot;activity_name&quot;,&quot;operator&quot;:&quot;&lt;=&quot;,&quot;value&quot;:1}</para>
        /// </summary>
        [NameInMap("RuleThreshold")]
        [Validation(Required=false)]
        public string RuleThreshold { get; set; }

        /// <summary>
        /// <para>The threat level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>serious: high</para>
        /// </description></item>
        /// <item><description><para>suspicious: medium</para>
        /// </description></item>
        /// <item><description><para>remind: low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>remind</para>
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public string ThreatLevel { get; set; }

    }

}
