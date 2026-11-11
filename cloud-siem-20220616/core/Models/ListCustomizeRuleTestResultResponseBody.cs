// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCustomizeRuleTestResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomizeRuleTestResultResponseBodyData Data { get; set; }
        public class ListCustomizeRuleTestResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListCustomizeRuleTestResultResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListCustomizeRuleTestResultResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
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

                /// <summary>
                /// <para>The number of alerts that passed the verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("VerifiedCount")]
                [Validation(Required=false)]
                public long? VerifiedCount { get; set; }

            }

            /// <summary>
            /// <para>The detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListCustomizeRuleTestResultResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListCustomizeRuleTestResultResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The description of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The account you logged in this time is not in the legal account category defined by you. Please confirm the legality of the login behavior。</para>
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// <para>The details of the alert in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;main_user_id&quot;: &quot;165295629792****&quot;;&quot;log_uuid_count&quot;: &quot;99&quot;;&quot;attack_ip&quot;: &quot;218.92.XX.XX&quot;}</para>
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// <para>The product from which the alert associated with the event originates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// <para>The submodule of the product from which the alert associated with the event originates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>waf</para>
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// <para>The ATT&amp;CK technique tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T1595.002 Vulnerability Scanning</para>
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// <para>The name of the alert, which corresponds to the name of the custom rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>waf_scan</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The threat type, which is the alerting type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WEBSHELL</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The threat level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>serious: high</description></item>
                /// <item><description>suspicious: medium</description></item>
                /// <item><description>remind: low</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>remind</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The log source corresponding to the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_siem_aegis_sas_alert</para>
                /// </summary>
                [NameInMap("LogSource")]
                [Validation(Required=false)]
                public string LogSource { get; set; }

                /// <summary>
                /// <para>The time when the alert is recorded. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// <para>The log type corresponding to the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALERT_ACTIVITY</para>
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// <para>The ID of the primary account associated with the alert in SIEM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                /// <summary>
                /// <para>The status of the alert data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>test: business testing</description></item>
                /// <item><description>online: online</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public string OnlineStatus { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account associated with the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

                /// <summary>
                /// <para>The UUID of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// <para>The verification result of the alert based on the alert template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: passed</description></item>
                /// <item><description>false: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("VerifyType")]
                [Validation(Required=false)]
                public string VerifyType { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
