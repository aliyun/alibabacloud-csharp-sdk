// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetContainerDefenseRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The rule details.</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>防御规则。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The alert name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Non-image Process Startup</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EventName</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The alerting type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Container Active Defense</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EventType</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1948</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The rule action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: alert.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: block.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-000</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The switch status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: system rule.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: custom rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The scope in which the rule takes effect.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public List<GetContainerDefenseRuleDetailResponseBodyDataScope> Scope { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataScope : TeaModel {
                /// <summary>
                /// <para>Indicates whether all namespaces are included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: no.</description></item>
                /// <item><description><b>1</b>: yes.</description></item>
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
                /// <para>The list of namespaces.</para>
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
                /// <para>The list of file hashes.<notice>This parameter is not supported.</notice>.</para>
                /// </summary>
                [NameInMap("Hash")]
                [Validation(Required=false)]
                [Obsolete]
                public List<string> Hash { get; set; }

                /// <summary>
                /// <para>The list of images added to the whitelist.</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public List<string> Image { get; set; }

                /// <summary>
                /// <para>The list of file paths added to the whitelist.</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public List<string> Path { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the request was successful.</para>
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
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77546BF4-CCE8-5F8D-B42B-5FD3306B43B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful.</description></item>
        /// <item><description><b>false</b>: failed.</description></item>
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
