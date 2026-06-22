// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckFixDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of check item fix parameters.</para>
        /// </summary>
        [NameInMap("CheckFixDetails")]
        [Validation(Required=false)]
        public List<DescribeCheckFixDetailsResponseBodyCheckFixDetails> CheckFixDetails { get; set; }
        public class DescribeCheckFixDetailsResponseBodyCheckFixDetails : TeaModel {
            /// <summary>
            /// <para>The detailed description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Force users not to reuse recently used passwords to reduce the risk of password guessing attacks</para>
            /// </summary>
            [NameInMap("CheckDesc")]
            [Validation(Required=false)]
            public string CheckDesc { get; set; }

            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ensure password reuse is limited</para>
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// <para>The list of rules supported by the check item.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules> Rules { get; set; }
            public class DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules : TeaModel {
                /// <summary>
                /// <para>The ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                /// <summary>
                /// <para>The default value of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public int? DefaultValue { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is optional. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public int? Optional { get; set; }

                /// <summary>
                /// <para>The list of rule parameters.</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<DescribeCheckFixDetailsResponseBodyCheckFixDetailsRulesParamList> ParamList { get; set; }
                public class DescribeCheckFixDetailsResponseBodyCheckFixDetailsRulesParamList : TeaModel {
                    /// <summary>
                    /// <para>The options of the rule parameter when the parameter type is selection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0,1,2,3</para>
                    /// </summary>
                    [NameInMap("EnumValue")]
                    [Validation(Required=false)]
                    public string EnumValue { get; set; }

                    /// <summary>
                    /// <para>The maximum value of the rule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("MaxValue")]
                    [Validation(Required=false)]
                    public int? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value of the rule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("MinValue")]
                    [Validation(Required=false)]
                    public int? MinValue { get; set; }

                    /// <summary>
                    /// <para>The default value of the rule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ParamDefaultValue")]
                    [Validation(Required=false)]
                    public string ParamDefaultValue { get; set; }

                    /// <summary>
                    /// <para>The description of the rule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The setting value is 0 means no definition, 1 means success, 2 means failure, 3 means success and failure</para>
                    /// </summary>
                    [NameInMap("ParamDesc")]
                    [Validation(Required=false)]
                    public string ParamDesc { get; set; }

                    /// <summary>
                    /// <para>The name of the rule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>range_val</para>
                    /// </summary>
                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

                    /// <summary>
                    /// <para>The type of the rule parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: input</description></item>
                    /// <item><description><b>2</b>: selection.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public int? ParamType { get; set; }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pwd_reuse.system_auth</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    /// <summary>
                    /// <para>The configured value of the rule parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(/etc/system-auth)Force users not to reuse the number of recently used passwords between 5 and 24</para>
                /// </summary>
                [NameInMap("RuleDesc")]
                [Validation(Required=false)]
                public string RuleDesc { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pwd_reuse.system_auth</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The configured value of the rule parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>open</para>
                /// </summary>
                [NameInMap("VarName")]
                [Validation(Required=false)]
                public string VarName { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of check items that support fixing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DBF1E27-98D8-5EC2-9CF3-4A2E26F6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
