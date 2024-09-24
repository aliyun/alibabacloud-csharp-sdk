// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5B28F65-9245-5DC1-B3CF-5F2756A756A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the baseline check policy.</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeStrategyDetailResponseBodyStrategy Strategy { get; set; }
        public class DescribeStrategyDetailResponseBodyStrategy : TeaModel {
            /// <summary>
            /// <para>The type of the baseline check policy that you want to query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>common</b>: standard baseline check policy</description></item>
            /// <item><description><b>custom</b>: custom baseline check policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public string CustomType { get; set; }

            /// <summary>
            /// <para>The check interval of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }

            /// <summary>
            /// <para>The time period during which the check starts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: 00:00 to 06:00</description></item>
            /// <item><description><b>6</b>: 06:00 to 12:00</description></item>
            /// <item><description><b>12</b>: 12:00 to 18:00</description></item>
            /// <item><description><b>18</b>: 18:00 to 24:00</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }

            /// <summary>
            /// <para>The end time of the check. Specify the time in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The name of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestStrategy</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The subtype of the baselines. </para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to query the subtypes of baselines.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hc_nginx_linux,tomcat7,hc_mysql_ali,hc_docker</para>
            /// </summary>
            [NameInMap("RiskSubTypeName")]
            [Validation(Required=false)]
            public string RiskSubTypeName { get; set; }

            /// <summary>
            /// <para>The information about the whitelist of risk items.</para>
            /// </summary>
            [NameInMap("RiskTypeWhiteListQueryResultList")]
            [Validation(Required=false)]
            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList> RiskTypeWhiteListQueryResultList { get; set; }
            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList : TeaModel {
                /// <summary>
                /// <para>The alias of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unauthorized Access</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>Indicates whether the check item is selected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("On")]
                [Validation(Required=false)]
                public bool? On { get; set; }

                /// <summary>
                /// <para>The information about sub-check items.</para>
                /// </summary>
                [NameInMap("SubTypes")]
                [Validation(Required=false)]
                public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes> SubTypes { get; set; }
                public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes : TeaModel {
                    /// <summary>
                    /// <para>The alias of the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Redis unauthorized access high exploit vulnerability risk</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The details of custom check items.</para>
                    /// </summary>
                    [NameInMap("CheckDetails")]
                    [Validation(Required=false)]
                    public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails> CheckDetails { get; set; }
                    public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails : TeaModel {
                        /// <summary>
                        /// <para>The description of the check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Set password expiration time, force regular modification of password, reduce password leakage and guess risk.Use non-password login (e.g. key pair) please ignore this item.</para>
                        /// </summary>
                        [NameInMap("CheckDesc")]
                        [Validation(Required=false)]
                        public string CheckDesc { get; set; }

                        /// <summary>
                        /// <para>The ID of the check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>206</para>
                        /// </summary>
                        [NameInMap("CheckId")]
                        [Validation(Required=false)]
                        public long? CheckId { get; set; }

                        /// <summary>
                        /// <para>The check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Ensure password expiration period is set.</para>
                        /// </summary>
                        [NameInMap("CheckItem")]
                        [Validation(Required=false)]
                        public string CheckItem { get; set; }

                        /// <summary>
                        /// <para>The details of rules.</para>
                        /// </summary>
                        [NameInMap("Rules")]
                        [Validation(Required=false)]
                        public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules> Rules { get; set; }
                        public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules : TeaModel {
                            /// <summary>
                            /// <para>The default value of the rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public int? DefaultValue { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the rule can be selected. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>1</b>: yes</description></item>
                            /// <item><description><b>0</b>: no</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Optional")]
                            [Validation(Required=false)]
                            public int? Optional { get; set; }

                            /// <summary>
                            /// <para>The rule parameters.</para>
                            /// </summary>
                            [NameInMap("ParamList")]
                            [Validation(Required=false)]
                            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList : TeaModel {
                                /// <summary>
                                /// <para>The options that can be selected for the rule parameter if the value of ParamType is set to 2.</para>
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
                                /// <para>999</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public int? MaxValue { get; set; }

                                /// <summary>
                                /// <para>The minimum value of the rule parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public int? MinValue { get; set; }

                                /// <summary>
                                /// <para>The default value of the rule parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>7</para>
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
                                /// <item><description><b>2</b>: selection</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("ParamType")]
                                [Validation(Required=false)]
                                public int? ParamType { get; set; }

                                /// <summary>
                                /// <para>The configured value of the rule parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>7</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The description of the rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Please customize the password expiration time detection standard as</para>
                            /// </summary>
                            [NameInMap("RuleDesc")]
                            [Validation(Required=false)]
                            public string RuleDesc { get; set; }

                            /// <summary>
                            /// <para>The rule ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>login_unlock_deny_pam_faillock.must.cus</para>
                            /// </summary>
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>Indicates whether the sub-check item is selected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("On")]
                    [Validation(Required=false)]
                    public bool? On { get; set; }

                    /// <summary>
                    /// <para>The operating system type of the server. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>windows</b></description></item>
                    /// <item><description><b>linux</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>windows</para>
                    /// </summary>
                    [NameInMap("SupportedOs")]
                    [Validation(Required=false)]
                    public string SupportedOs { get; set; }

                    /// <summary>
                    /// <para>The type of the sub-check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hc_exploit_redis</para>
                    /// </summary>
                    [NameInMap("TypeName")]
                    [Validation(Required=false)]
                    public string TypeName { get; set; }

                }

                /// <summary>
                /// <para>The name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hc_exploit</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// <para>The start time of the check. Specify the time in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The method that is used to apply the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>groupId</b>: asset groups</description></item>
            /// <item><description><b>uuid</b>: assets</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>groupId</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The type of the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: standard policies</description></item>
            /// <item><description><b>2</b>: custom policies</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
