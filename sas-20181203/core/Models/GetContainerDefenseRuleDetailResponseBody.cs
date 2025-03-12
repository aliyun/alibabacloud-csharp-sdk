// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetContainerDefenseRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContainerDefenseRuleDetailResponseBodyData Data { get; set; }
        public class GetContainerDefenseRuleDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104***</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom defense configuration</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The alert name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Non-image Program Startup</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EventName</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The alert type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Proactive Defense for Containers</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EventType</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1948</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The action specified in the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: alert</description></item>
            /// <item><description><b>2</b>: block</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-000</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: system rule</description></item>
            /// <item><description><b>2</b>: custom rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The effective scope of the rule.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public List<GetContainerDefenseRuleDetailResponseBodyDataScope> Scope { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataScope : TeaModel {
                /// <summary>
                /// <para>Indicates whether all namespaces are included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: no</description></item>
                /// <item><description><b>1</b>: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                /// <summary>
                /// <para>The ID of the container cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c9bea04<em>2b25</em>*</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>An array that consists of queried namespaces.</para>
                /// </summary>
                [NameInMap("Namespaces")]
                [Validation(Required=false)]
                public List<string> Namespaces { get; set; }

            }

            /// <summary>
            /// <para>The whitelist.</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public GetContainerDefenseRuleDetailResponseBodyDataWhitelist Whitelist { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataWhitelist : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The hash values of the files that are added to the whitelist.</para>
                /// <remarks>
                /// <para> This parameter is not supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Hash")]
                [Validation(Required=false)]
                [Obsolete]
                public List<string> Hash { get; set; }

                /// <summary>
                /// <para>An array consisting of images that are added to the whitelist.</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public List<string> Image { get; set; }

                /// <summary>
                /// <para>The paths to the files that are added to the whitelist.</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public List<string> Path { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77546BF4-CCE8-5F8D-B42B-5FD3306B43B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
