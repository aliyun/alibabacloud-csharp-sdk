// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PostCustomizeRuleResponseBodyData Data { get; set; }
        public class PostCustomizeRuleResponseBodyData : TeaModel {
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
            /// <para>The ID of the Alibaba Cloud account that is used to purchase Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127608589417****</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }

            /// <summary>
            /// <para>The ATT\&amp;CK attack technique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>T1595.002 Vulnerability Scanning</para>
            /// </summary>
            [NameInMap("AttCk")]
            [Validation(Required=false)]
            public string AttCk { get; set; }

            /// <summary>
            /// <para>The data type of the condition field in the automated response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// <para>The extended information for event generation. This parameter is returned only when EventTransferType is set to allToSingle. The value indicates the length and unit of the alert aggregation window. You must unescape the HTML escape characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;MINUTE&quot;}</para>
            /// </summary>
            [NameInMap("EventTransferExt")]
            [Validation(Required=false)]
            public string EventTransferExt { get; set; }

            /// <summary>
            /// <para>Indicates whether alerts are converted into events. Valid values:</para>
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
            /// <para>The time when the custom rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06 16:37:29</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the custom rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06 16:37:29</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

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
            /// <para>The length of the rule window. You must unescape the HTML escape characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;HOUR&quot;}</para>
            /// </summary>
            [NameInMap("QueryCycle")]
            [Validation(Required=false)]
            public string QueryCycle { get; set; }

            /// <summary>
            /// <para>The query condition of the rule in the JSON format. You must unescape the HTML escape characters.</para>
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
            /// <para>The fields that are used to group logs. The value is a JSON array. You must unescape the HTML escape characters.</para>
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
            /// <para>The threshold configuration of the rule in the JSON format. You must unescape the HTML escape characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;aggregateFunction&quot;:&quot;count&quot;,&quot;aggregateFunctionName&quot;:&quot;count&quot;,&quot;field&quot;:&quot;activity_name&quot;,&quot;operator&quot;:&quot;&lt;=&quot;,&quot;value&quot;:1}</para>
            /// </summary>
            [NameInMap("RuleThreshold")]
            [Validation(Required=false)]
            public string RuleThreshold { get; set; }

            /// <summary>
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>predefine: predefined</para>
            /// </description></item>
            /// <item><description><para>customize: custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>customize</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: initial</para>
            /// </description></item>
            /// <item><description><para>10: testing with simulated data</para>
            /// </description></item>
            /// <item><description><para>15: testing with business data</para>
            /// </description></item>
            /// <item><description><para>20: test with business data ends</para>
            /// </description></item>
            /// <item><description><para>100: published</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

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

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
