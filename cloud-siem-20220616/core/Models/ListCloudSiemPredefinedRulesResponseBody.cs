// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemPredefinedRulesResponseBody : TeaModel {
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
        public ListCloudSiemPredefinedRulesResponseBodyData Data { get; set; }
        public class ListCloudSiemPredefinedRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListCloudSiemPredefinedRulesResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListCloudSiemPredefinedRulesResponseBodyDataPageInfo : TeaModel {
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
                /// <para>The number of entries returned per page.</para>
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
            public List<ListCloudSiemPredefinedRulesResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListCloudSiemPredefinedRulesResponseBodyDataResponseData : TeaModel {
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
                /// <para>The ATT\&amp;CK technique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T1595.002 Vulnerability Scanning</para>
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// <para>The event generation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>default: the default built-in method</para>
                /// </description></item>
                /// <item><description><para>singleToSingle: An event is generated for each alert.</para>
                /// </description></item>
                /// <item><description><para>allToSingle: An event is generated for all alerts in an epoch.</para>
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
                /// <para>The time when the rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the rule was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the predefined rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The Medusa code of the rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${siem_rule_description_siem_cfw-attack-count-level-up_cfw-attack}</para>
                /// </summary>
                [NameInMap("RuleDescMds")]
                [Validation(Required=false)]
                public string RuleDescMds { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>siem_base64-command-exec_aegis-proc</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The Chinese name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>siem_base64-command-exec_aegis-proc</para>
                /// </summary>
                [NameInMap("RuleNameCn")]
                [Validation(Required=false)]
                public string RuleNameCn { get; set; }

                /// <summary>
                /// <para>The English name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>siem_base64-command-exec_aegis-proc</para>
                /// </summary>
                [NameInMap("RuleNameEn")]
                [Validation(Required=false)]
                public string RuleNameEn { get; set; }

                /// <summary>
                /// <para>The Medusa code of the rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${siem_rule_name_siem_cfw-attack-count-level-up_cfw-attack}</para>
                /// </summary>
                [NameInMap("RuleNameMds")]
                [Validation(Required=false)]
                public string RuleNameMds { get; set; }

                /// <summary>
                /// <para>The log source of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_siem_aegis_proc</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The status of the predefined rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: initial</para>
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
