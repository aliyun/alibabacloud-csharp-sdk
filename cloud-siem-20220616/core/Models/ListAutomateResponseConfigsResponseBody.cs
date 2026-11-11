// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAutomateResponseConfigsResponseBody : TeaModel {
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
        public ListAutomateResponseConfigsResponseBodyData Data { get; set; }
        public class ListAutomateResponseConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListAutomateResponseConfigsResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListAutomateResponseConfigsResponseBodyDataPageInfo : TeaModel {
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

            }

            /// <summary>
            /// <para>The detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListAutomateResponseConfigsResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListAutomateResponseConfigsResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The action configuration of the automated response rule, in JSON array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///       {
                ///             &quot;actionType&quot;: &quot;doPlaybook&quot;,
                ///             &quot;playbookName&quot;: &quot;WafBlockIP&quot;,
                ///             &quot;playbookUuid&quot;: &quot;bdad6220-6584-41b2-9704-fc6584568758&quot;
                ///       }
                /// ]</para>
                /// </summary>
                [NameInMap("ActionConfig")]
                [Validation(Required=false)]
                public string ActionConfig { get; set; }

                /// <summary>
                /// <para>The types of the actions. Multiple values are separated by commas. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>doPlaybook</b>: Execute a playbook.</description></item>
                /// <item><description><b>changeEventStatus</b>: Change the event status.</description></item>
                /// <item><description><b>changeThreatLevel</b>: Change the event threat level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>doPlaybook,changeEventStatus</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>The ID of the primary Alibaba Cloud account associated with the SIEM rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <para>The type of the automated response. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>event</b>: Event.</description></item>
                /// <item><description><b>alert</b>: Alert.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>event</para>
                /// </summary>
                [NameInMap("AutoResponseType")]
                [Validation(Required=false)]
                public string AutoResponseType { get; set; }

                /// <summary>
                /// <para>The data type of the condition field in the automated response rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public int? DataType { get; set; }

                /// <summary>
                /// <para>The cause of the automated response rule, in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;left&quot;:{&quot;value&quot;:&quot;alert_name&quot;},&quot;operator&quot;:&quot;containsString&quot;,&quot;right&quot;:{&quot;value&quot;:&quot;webshell_online&quot;}}]</para>
                /// </summary>
                [NameInMap("ExecutionCondition")]
                [Validation(Required=false)]
                public string ExecutionCondition { get; set; }

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
                /// <para>The ID of the automated response rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The type of the response rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>preset: Predefined.</description></item>
                /// <item><description>custom: Custom.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("ResponseRuleType")]
                [Validation(Required=false)]
                public string ResponseRuleType { get; set; }

                /// <summary>
                /// <para>The name of the automated response rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfw kill quara book</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The status of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Disabled.</description></item>
                /// <item><description><b>100</b>: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17108579417****</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

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
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
