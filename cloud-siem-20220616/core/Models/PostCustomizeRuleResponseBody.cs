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
            /// <para>The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127608589417****</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }

            /// <summary>
            /// <para>告警附加字段attck</para>
            /// 
            /// <b>Example:</b>
            /// <para>T1595.002 Vulnerability Scanning</para>
            /// </summary>
            [NameInMap("AttCk")]
            [Validation(Required=false)]
            public string AttCk { get; set; }

            /// <summary>
            /// <para>自动化响应规则条件字段数据类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// <para>The extended information about event generation. If eventTransferType is set to allToSingle, the value of this parameter indicates the length and unit of the alert aggregation window. The HTML escape characters are reversed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;MINUTE&quot;}</para>
            /// </summary>
            [NameInMap("EventTransferExt")]
            [Validation(Required=false)]
            public string EventTransferExt { get; set; }

            /// <summary>
            /// <para>Indicates whether the system generates an event for the alert. Valid values:</para>
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
            /// <para>The window length of the rule. The HTML escape characters are reversed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;HOUR&quot;}</para>
            /// </summary>
            [NameInMap("QueryCycle")]
            [Validation(Required=false)]
            public string QueryCycle { get; set; }

            /// <summary>
            /// <para>The query condition of the rule. The value is in the JSON format. The HTML escape characters are reversed.</para>
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
            /// <para>The log aggregation field of the rule. The value is a JSON string. The HTML escape characters are reversed.</para>
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
            /// <para>The threshold configuration of the rule. The value is in the JSON format. The HTML escape characters are reversed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;aggregateFunction&quot;:&quot;count&quot;,&quot;aggregateFunctionName&quot;:&quot;count&quot;,&quot;field&quot;:&quot;activity_name&quot;,&quot;operator&quot;:&quot;&lt;=&quot;,&quot;value&quot;:1}</para>
            /// </summary>
            [NameInMap("RuleThreshold")]
            [Validation(Required=false)]
            public string RuleThreshold { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>predefine</description></item>
            /// <item><description>customize</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>customize</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The rule is in the initial state.</description></item>
            /// <item><description>10: The simulation data is tested.</description></item>
            /// <item><description>15: The business data is being tested.</description></item>
            /// <item><description>20: The business data test ends.</description></item>
            /// <item><description>100: The rule takes effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
