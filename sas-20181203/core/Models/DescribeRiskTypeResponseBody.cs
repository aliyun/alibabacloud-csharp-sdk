// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F22037B5-FCE4-5178-A9E7-71798E1F9270</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about baseline types.</para>
        /// </summary>
        [NameInMap("RiskTypes")]
        [Validation(Required=false)]
        public List<DescribeRiskTypeResponseBodyRiskTypes> RiskTypes { get; set; }
        public class DescribeRiskTypeResponseBodyRiskTypes : TeaModel {
            /// <summary>
            /// <para>The alias of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Redis unauthorized access high exploit vulnerability risk</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The baseline type flag of the current user version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Have access</description></item>
            /// <item><description><b>false</b>: No permissions</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthFlag")]
            [Validation(Required=false)]
            public bool? AuthFlag { get; set; }

            /// <summary>
            /// <para>An array that consists of the information about baseline subtypes.</para>
            /// </summary>
            [NameInMap("SubTypes")]
            [Validation(Required=false)]
            public List<DescribeRiskTypeResponseBodyRiskTypesSubTypes> SubTypes { get; set; }
            public class DescribeRiskTypeResponseBodyRiskTypesSubTypes : TeaModel {
                /// <summary>
                /// <para>The alias of the baseline subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Redis unauthorized access high exploit vulnerability risk</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The baseline subtype permission flag of the current user version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Have access</description></item>
                /// <item><description><b>false</b>: No permissions</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AuthFlag")]
                [Validation(Required=false)]
                public bool? AuthFlag { get; set; }

                /// <summary>
                /// <para>An array that consists of the check details about the baseline subtype.</para>
                /// </summary>
                [NameInMap("CheckDetails")]
                [Validation(Required=false)]
                public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails> CheckDetails { get; set; }
                public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails : TeaModel {
                    /// <summary>
                    /// <para>The description of the baseline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Set password expiration time, force regular modification of password, reduce password leakage and guess risk.Use non-password login (e.g. key pair) please ignore this item.</para>
                    /// </summary>
                    [NameInMap("CheckDesc")]
                    [Validation(Required=false)]
                    public string CheckDesc { get; set; }

                    /// <summary>
                    /// <para>The ID of the baseline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1299</para>
                    /// </summary>
                    [NameInMap("CheckId")]
                    [Validation(Required=false)]
                    public long? CheckId { get; set; }

                    /// <summary>
                    /// <para>The baseline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ensure password expiration period is set.</para>
                    /// </summary>
                    [NameInMap("CheckItem")]
                    [Validation(Required=false)]
                    public string CheckItem { get; set; }

                    /// <summary>
                    /// <para>An array that consists of the rule details about the baseline.</para>
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules> Rules { get; set; }
                    public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the baseline can be edited. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: no</description></item>
                        /// <item><description><b>1</b>: yes</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Optional")]
                        [Validation(Required=false)]
                        public int? Optional { get; set; }

                        /// <summary>
                        /// <para>An array that consists of the parameters in the rule for the baseline.</para>
                        /// </summary>
                        [NameInMap("ParamList")]
                        [Validation(Required=false)]
                        public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                        public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRulesParamList : TeaModel {
                            /// <summary>
                            /// <para>If the value of paramType is 1, this parameter is empty. If the value of paramType is 2, this parameter provides the options that can be selected for paramType.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0,1,2,3</para>
                            /// </summary>
                            [NameInMap("EnumValue")]
                            [Validation(Required=false)]
                            public string EnumValue { get; set; }

                            /// <summary>
                            /// <para>The maximum value of the parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>999</para>
                            /// </summary>
                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public int? MaxValue { get; set; }

                            /// <summary>
                            /// <para>The minimum value of the parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public int? MinValue { get; set; }

                            /// <summary>
                            /// <para>The default value of the parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>7</para>
                            /// </summary>
                            [NameInMap("ParamDefaultValue")]
                            [Validation(Required=false)]
                            public string ParamDefaultValue { get; set; }

                            /// <summary>
                            /// <para>The description of the parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The setting value is 0 means no definition, 1 means success, 2 means failure, 3 means success and failure</para>
                            /// </summary>
                            [NameInMap("ParamDesc")]
                            [Validation(Required=false)]
                            public string ParamDesc { get; set; }

                            /// <summary>
                            /// <para>The name of the parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>range_val</para>
                            /// </summary>
                            [NameInMap("ParamName")]
                            [Validation(Required=false)]
                            public string ParamName { get; set; }

                            /// <summary>
                            /// <para>The configuration type of the parameter. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>1</b>: input</description></item>
                            /// <item><description><b>2</b>: selection</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("ParamType")]
                            [Validation(Required=false)]
                            public int? ParamType { get; set; }

                        }

                        /// <summary>
                        /// <para>The description of the rule for the baseline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Please customize the password expiration time detection standard as</para>
                        /// </summary>
                        [NameInMap("RuleDesc")]
                        [Validation(Required=false)]
                        public string RuleDesc { get; set; }

                        /// <summary>
                        /// <para>The ID of the rule for the baseline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>audit.audit_policy.auditpolicychange.cus</para>
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The operating system type of the server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>windows</b></description></item>
                /// <item><description><b>linux</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("SupportedOs")]
                [Validation(Required=false)]
                public string SupportedOs { get; set; }

                /// <summary>
                /// <para>The name of the baseline subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hc_exploit_redis</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// <para>The name of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc_exploit</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
