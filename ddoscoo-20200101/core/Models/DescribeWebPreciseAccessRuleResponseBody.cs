// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebPreciseAccessRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the accurate access control rule that is created for the website.</para>
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
            /// <para>The scheduling rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList> RuleList { get; set; }
            public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList : TeaModel {
                /// <summary>
                /// <para>The action triggered if the rule is matched. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b>: The requests that match the rule are allowed.</description></item>
                /// <item><description><b>block</b>: The requests that match the rule are blocked.</description></item>
                /// <item><description><b>challenge</b>: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The match conditions.</para>
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
                    /// <para>The custom HTTP request header.</para>
                    /// <remarks>
                    /// <para> This parameter takes effect only when <b>Field</b> is set to <b>header</b>.</para>
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

                [NameInMap("ExpirePeriod")]
                [Validation(Required=false)]
                public long? ExpirePeriod { get; set; }

                /// <summary>
                /// <para>The validity period of the rule. Unit: seconds. This parameter takes effect only when <b>action</b> of a rule is <b>block</b>. Access requests that match the rule are blocked within the specified validity period of the rule. The value <b>0</b> indicates that the whitelist takes effect all the time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Expires")]
                [Validation(Required=false)]
                public long? Expires { get; set; }

                /// <summary>
                /// <para>The name of the scheduling rule.</para>
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
                /// <item><description><b>manual</b> (default): manually created.</description></item>
                /// <item><description><b>auto</b>: automatically generated.</description></item>
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
