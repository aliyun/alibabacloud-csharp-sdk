// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebPreciseAccessRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The precise access control rules for the website.</para>
        /// </summary>
        [NameInMap("PreciseAccessConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigList> PreciseAccessConfigList { get; set; }
        public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigList : TeaModel {
            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList> RuleList { get; set; }
            public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList : TeaModel {
                /// <summary>
                /// <para>The action that is performed on requests that match the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>accept</b>: allows the requests.</para>
                /// </description></item>
                /// <item><description><para><b>block</b>: blocks the requests.</para>
                /// </description></item>
                /// <item><description><para><b>challenge</b>: triggers a JavaScript Challenge for the requests.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of match conditions.</para>
                /// </summary>
                [NameInMap("ConditionList")]
                [Validation(Required=false)]
                public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleListConditionList> ConditionList { get; set; }
                public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleListConditionList : TeaModel {
                    /// <summary>
                    /// <para>The match content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.1.1.1</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The match conditions of the rule. The value is a JSON string. The value contains the following fields:</para>
                    /// <remarks>
                    /// <para>If you specify multiple match conditions, the logical relation between these conditions is AND.</para>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description><para><b>field</b>: The match field. This parameter is of the string type.</para>
                    /// </description></item>
                    /// <item><description><para><b>match_method</b>: The match method. This parameter is of the string type.</para>
                    /// <remarks>
                    /// <para>For more information about the valid values of <b>field</b> and <b>match_method</b>, see the &quot;Additional information about field and match_method&quot; section in this topic.</para>
                    /// </remarks>
                    /// </description></item>
                    /// <item><description><para><b>content</b>: The match content. This parameter is of the string type.</para>
                    /// </description></item>
                    /// <item><description><para><b>header_name</b>: The name of the header field. This parameter is of the string type. This parameter is required only when <b>field</b> is set to <b>header</b>.</para>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("ContentList")]
                    [Validation(Required=false)]
                    public List<string> ContentList { get; set; }

                    /// <summary>
                    /// <para>The match field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>The name of the custom HTTP header field.</para>
                    /// <remarks>
                    /// <para>This parameter is required only when <b>Field</b> is set to <b>header</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The logical operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>belong</para>
                    /// </summary>
                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                /// <summary>
                /// <para>The validity period of the rule. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1598889600</para>
                /// </summary>
                [NameInMap("ExpirePeriod")]
                [Validation(Required=false)]
                public long? ExpirePeriod { get; set; }

                /// <summary>
                /// <para>The validity period of the rule. Unit: seconds. This parameter is required only when the <b>action</b> of the rule is <b>block</b>. Requests that match the rule are blocked within the validity period. A value of <b>0</b> indicates that the rule is permanently valid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Expires")]
                [Validation(Required=false)]
                public long? Expires { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testrule</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>manual</b> (default): The rule is manually created.</para>
                /// </description></item>
                /// <item><description><para><b>clover</b>: The rule is automatically generated.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>209EEFBF-B0C7-441E-8C28-D0945A57A638</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
