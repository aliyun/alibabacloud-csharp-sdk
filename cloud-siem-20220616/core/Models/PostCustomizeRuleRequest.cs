// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The internal code of the risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${siem_rule_type_process_abnormal_command}</para>
        /// </summary>
        [NameInMap("AlertTypeMds")]
        [Validation(Required=false)]
        public string AlertTypeMds { get; set; }

        /// <summary>
        /// <para>att&amp;ck.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T1595.002 Vulnerability Scanning</para>
        /// </summary>
        [NameInMap("AttCk")]
        [Validation(Required=false)]
        public string AttCk { get; set; }

        /// <summary>
        /// <para>The extended information about event generation. If eventTransferType is set to allToSingle, the value of this parameter indicates the length and unit of the alert aggregation window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;MINUTE&quot;}</para>
        /// </summary>
        [NameInMap("EventTransferExt")]
        [Validation(Required=false)]
        public string EventTransferExt { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert an alert to an event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no</description></item>
        /// <item><description>1: yes</description></item>
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
        /// <item><description>default: The default method is used.</description></item>
        /// <item><description>singleToSingle: The system generates an event for each alert.</description></item>
        /// <item><description>allToSingle: The system generates an event for alerts within a period of time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>allToSingle</para>
        /// </summary>
        [NameInMap("EventTransferType")]
        [Validation(Required=false)]
        public string EventTransferType { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
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
        /// <para>The internal code of the log source.</para>
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
        /// <para>The internal code of the log type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${security_event_config.event_name.webshellName_clientav}</para>
        /// </summary>
        [NameInMap("LogTypeMds")]
        [Validation(Required=false)]
        public string LogTypeMds { get; set; }

        /// <summary>
        /// <para>The window length of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;HOUR&quot;}</para>
        /// </summary>
        [NameInMap("QueryCycle")]
        [Validation(Required=false)]
        public string QueryCycle { get; set; }

        /// <summary>
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in regions in China.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the account that you switch from the management account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the current Alibaba Cloud account</description></item>
        /// <item><description>1: the global account</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The query condition of the rule. The value is in the JSON format.</para>
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
        /// <para>The log aggregation field of the rule. The value is a JSON string.</para>
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
        /// <para>The threshold configuration of the rule. The value is in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aggregateFunction&quot;:&quot;count&quot;,&quot;aggregateFunctionName&quot;:&quot;count&quot;,&quot;field&quot;:&quot;activity_name&quot;,&quot;operator&quot;:&quot;&lt;=&quot;,&quot;value&quot;:1}</para>
        /// </summary>
        [NameInMap("RuleThreshold")]
        [Validation(Required=false)]
        public string RuleThreshold { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>serious: high</description></item>
        /// <item><description>suspicious: medium</description></item>
        /// <item><description>remind: low</description></item>
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
