// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemCustomizeRulesResponseBody : TeaModel {
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
        public ListCloudSiemCustomizeRulesResponseBodyData Data { get; set; }
        public class ListCloudSiemCustomizeRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListCloudSiemCustomizeRulesResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListCloudSiemCustomizeRulesResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

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
                /// <para>The total number of entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListCloudSiemCustomizeRulesResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListCloudSiemCustomizeRulesResponseBodyDataResponseData : TeaModel {
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
                /// <para>The ID of the Alibaba Cloud account.</para>
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
                /// <para>The view type.</para>
                /// <para>0: the view of the current Alibaba Cloud account.
                /// 1: the view of all members in the enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public int? DataType { get; set; }

                /// <summary>
                /// <para>The extended information for event generation. This parameter is returned only when <b>EventTransferType</b> is set to <b>allToSingle</b>. The value is a JSON-formatted string that indicates the window length and unit for alert aggregation. You must unescape the HTML escape characters in the string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;MINUTE&quot;}</para>
                /// </summary>
                [NameInMap("EventTransferExt")]
                [Validation(Required=false)]
                public string EventTransferExt { get; set; }

                /// <summary>
                /// <para>Indicates whether to convert alerts into events. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: no</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: yes</para>
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
                /// <item><description><para><b>default</b>: the default method</para>
                /// </description></item>
                /// <item><description><para><b>singleToSingle</b>: An event is generated for each alert.</para>
                /// </description></item>
                /// <item><description><para><b>allToSingle</b>: An event is generated for all alerts within a period.</para>
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
                /// <para>The log source that is associated with the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_siem_aegis_sas_alert</para>
                /// </summary>
                [NameInMap("LogSource")]
                [Validation(Required=false)]
                public string LogSource { get; set; }

                /// <summary>
                /// <para>The Medusa code of the log source that is associated with the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${sas.cloudsiem.prod.cloud_siem_aegis_sas_alert}</para>
                /// </summary>
                [NameInMap("LogSourceMds")]
                [Validation(Required=false)]
                public string LogSourceMds { get; set; }

                /// <summary>
                /// <para>The log type that is associated with the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALERT_ACTIVITY</para>
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// <para>The Medusa code of the log type that is associated with the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${sas.cloudsiem.prod.alert_activity}</para>
                /// </summary>
                [NameInMap("LogTypeMds")]
                [Validation(Required=false)]
                public string LogTypeMds { get; set; }

                /// <summary>
                /// <para>The window length of the rule, which is a JSON-formatted string. You must unescape the HTML escape characters in the string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;time&quot;:&quot;1&quot;,&quot;unit&quot;:&quot;HOUR&quot;}</para>
                /// </summary>
                [NameInMap("QueryCycle")]
                [Validation(Required=false)]
                public string QueryCycle { get; set; }

                /// <summary>
                /// <para>The query condition of the rule, which is a JSON-formatted string that represents an array. You must unescape the HTML escape characters in the string.</para>
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
                /// <para>The aggregation field of the log, which is a JSON-formatted string that represents an array. You must unescape the HTML escape characters in the string.</para>
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
                /// <para>The threshold of the rule, which is a JSON-formatted string. You must unescape the HTML escape characters in the string.</para>
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
                /// <item><description><para><b>predefine</b>: predefined</para>
                /// </description></item>
                /// <item><description><para><b>customize</b>: custom</para>
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
                /// <item><description><para><b>0</b>: initial</para>
                /// </description></item>
                /// <item><description><para><b>10</b>: testing with simulated data</para>
                /// </description></item>
                /// <item><description><para><b>15</b>: testing with business data</para>
                /// </description></item>
                /// <item><description><para><b>20</b>: testing with business data is complete</para>
                /// </description></item>
                /// <item><description><para><b>100</b>: published</para>
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
                /// <item><description><para><b>serious</b>: high</para>
                /// </description></item>
                /// <item><description><para><b>suspicious</b>: medium</para>
                /// </description></item>
                /// <item><description><para><b>remind</b>: low</para>
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
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
