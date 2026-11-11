// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeWhiteRuleListResponseBody : TeaModel {
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
        public DescribeWhiteRuleListResponseBodyData Data { get; set; }
        public class DescribeWhiteRuleListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeWhiteRuleListResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeWhiteRuleListResponseBodyDataPageInfo : TeaModel {
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
            public List<DescribeWhiteRuleListResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeWhiteRuleListResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The identifier of the alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertNameId")]
                [Validation(Required=false)]
                public string AlertNameId { get; set; }

                /// <summary>
                /// <para>The alerting type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scan</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>The alerting type identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scan</para>
                /// </summary>
                [NameInMap("AlertTypeId")]
                [Validation(Required=false)]
                public string AlertTypeId { get; set; }

                /// <summary>
                /// <para>The UUID of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID that activated Cloud Threat Detection and Response (CTDR).</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <para>The rule set in JSON array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;conditions&quot;:[{&quot;isNot&quot;:false,&quot;itemId&quot;:0,&quot;left&quot;:{&quot;value&quot;:&quot;host_uuid.host_name&quot;},&quot;operator&quot;:&quot;containsString&quot;,&quot;right&quot;:{&quot;value&quot;:&quot;Cloud-MCH&quot;}}]}]</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public DescribeWhiteRuleListResponseBodyDataResponseDataExpression Expression { get; set; }
                public class DescribeWhiteRuleListResponseBodyDataResponseDataExpression : TeaModel {
                    /// <summary>
                    /// <para>The array of rule expressions.</para>
                    /// </summary>
                    [NameInMap("Conditions")]
                    [Validation(Required=false)]
                    public List<DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditions> Conditions { get; set; }
                    public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditions : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to negate the result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: Negated.</description></item>
                        /// <item><description>false: Not negated.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsNot")]
                        [Validation(Required=false)]
                        public bool? IsNot { get; set; }

                        /// <summary>
                        /// <para>The condition ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public int? ItemId { get; set; }

                        /// <summary>
                        /// <para>The left value of the condition.</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsLeft Left { get; set; }
                        public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsLeft : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether the left value is a variable. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: Variable.</description></item>
                            /// <item><description>false: Constant.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsVar")]
                            [Validation(Required=false)]
                            public bool? IsVar { get; set; }

                            /// <summary>
                            /// <para>The remark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>length</para>
                            /// </summary>
                            [NameInMap("Modifier")]
                            [Validation(Required=false)]
                            public string Modifier { get; set; }

                            /// <summary>
                            /// <para>The key-value pair for the remark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;key&quot;:&quot;{\&quot;tage\&quot;:\&quot;description\&quot;}&quot;}</para>
                            /// </summary>
                            [NameInMap("ModifierParam")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ModifierParam { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the left value is a constant. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: Yes.</description></item>
                            /// <item><description>false: No.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The variable name of the left value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ip</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The aggregation method for dispatch rule conditions. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>=</c>: Equal to.</description></item>
                        /// <item><description><c>&lt;&gt;</c>: Not equal to.</description></item>
                        /// <item><description><c>in</c>: Included in.</description></item>
                        /// <item><description><c>not in</c>: Not included in.</description></item>
                        /// <item><description><c>REGEXP</c>: Matches the regular expression.</description></item>
                        /// <item><description><c>NOT REGEXP</c>: Does not match the regular expression.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>REGEXP</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The right value object.</para>
                        /// </summary>
                        [NameInMap("Right")]
                        [Validation(Required=false)]
                        public DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsRight Right { get; set; }
                        public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsRight : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether the right value is a constant or a runtime variable that obtains its value from the runtime context. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: Runtime variable.</description></item>
                            /// <item><description>false: Constant.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("IsVar")]
                            [Validation(Required=false)]
                            public bool? IsVar { get; set; }

                            /// <summary>
                            /// <para>The remark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>length</para>
                            /// </summary>
                            [NameInMap("Modifier")]
                            [Validation(Required=false)]
                            public string Modifier { get; set; }

                            /// <summary>
                            /// <para>The key-value pair for the remark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;key&quot;:&quot;{\&quot;tage\&quot;:\&quot;description\&quot;}&quot;}</para>
                            /// </summary>
                            [NameInMap("ModifierParam")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ModifierParam { get; set; }

                            /// <summary>
                            /// <para>The data type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>String</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The right value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>12345</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The logical relationship of the conditions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>(1&amp;2)|(3&amp;4)</para>
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public string Logic { get; set; }

                }

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
                /// <para>The time when the rule was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The unique ID of the allowlist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The globally unique UUID of the incident.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>The enabled status of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Enabled.</description></item>
                /// <item><description>0: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID that created the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

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
        /// <para>The request ID.</para>
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
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
