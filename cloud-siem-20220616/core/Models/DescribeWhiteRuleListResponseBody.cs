// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeWhiteRuleListResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWhiteRuleListResponseBodyData Data { get; set; }
        public class DescribeWhiteRuleListResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeWhiteRuleListResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeWhiteRuleListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The current page number.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The detailed data.
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeWhiteRuleListResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeWhiteRuleListResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The alert name.
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The ID of the alert name.
                /// </summary>
                [NameInMap("AlertNameId")]
                [Validation(Required=false)]
                public string AlertNameId { get; set; }

                /// <summary>
                /// The alert type.
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// The ID of the alert type.
                /// </summary>
                [NameInMap("AlertTypeId")]
                [Validation(Required=false)]
                public string AlertTypeId { get; set; }

                /// <summary>
                /// The UUID of the alert.
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// The conditions in the rule. The value is a JSON array.
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public DescribeWhiteRuleListResponseBodyDataResponseDataExpression Expression { get; set; }
                public class DescribeWhiteRuleListResponseBodyDataResponseDataExpression : TeaModel {
                    /// <summary>
                    /// The rule conditions.
                    /// </summary>
                    [NameInMap("Conditions")]
                    [Validation(Required=false)]
                    public List<DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditions> Conditions { get; set; }
                    public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditions : TeaModel {
                        /// <summary>
                        /// Indicates whether the result is inverted. Valid values:
                        /// 
                        /// *   true
                        /// *   false
                        /// </summary>
                        [NameInMap("IsNot")]
                        [Validation(Required=false)]
                        public bool? IsNot { get; set; }

                        /// <summary>
                        /// The ID of the rule condition.
                        /// </summary>
                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public int? ItemId { get; set; }

                        /// <summary>
                        /// The left operand of the rule condition.
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsLeft Left { get; set; }
                        public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsLeft : TeaModel {
                            /// <summary>
                            /// Indicates whether the left operand is a variable. Valid values:
                            /// 
                            /// *   true: variable
                            /// *   false: constant
                            /// </summary>
                            [NameInMap("IsVar")]
                            [Validation(Required=false)]
                            public bool? IsVar { get; set; }

                            /// <summary>
                            /// The remarks on the left operand.
                            /// </summary>
                            [NameInMap("Modifier")]
                            [Validation(Required=false)]
                            public string Modifier { get; set; }

                            /// <summary>
                            /// The key-value pair information of the remarks.
                            /// </summary>
                            [NameInMap("ModifierParam")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ModifierParam { get; set; }

                            /// <summary>
                            /// Indicates whether the left operand is a constant. Valid values:
                            /// 
                            /// *   true
                            /// *   false
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// The variable of the left operand.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The logical operator of the rule condition. Valid values:
                        /// 
                        /// *   `=`: equals to
                        /// *   `<>`: does not equal to
                        /// *   `in`: contains
                        /// *   `not in`: does not contain
                        /// *   `REGEXP`: matches a regular expression
                        /// *   `NOT REGEXP`: does not match a regular expression
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// The right operand of the rule condition.
                        /// </summary>
                        [NameInMap("Right")]
                        [Validation(Required=false)]
                        public DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsRight Right { get; set; }
                        public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsRight : TeaModel {
                            /// <summary>
                            /// Indicates whether the right operand is a constant or a runtime variable that is obtained from the runtime context. Valid values:
                            /// 
                            /// *   true: runtime variable
                            /// *   false: constant
                            /// </summary>
                            [NameInMap("IsVar")]
                            [Validation(Required=false)]
                            public bool? IsVar { get; set; }

                            /// <summary>
                            /// The remarks on the right operand.
                            /// </summary>
                            [NameInMap("Modifier")]
                            [Validation(Required=false)]
                            public string Modifier { get; set; }

                            /// <summary>
                            /// The key-value pair information of the remarks.
                            /// </summary>
                            [NameInMap("ModifierParam")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ModifierParam { get; set; }

                            /// <summary>
                            /// The data type of the right operand.
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// The right operand.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The logical relationships among the rule conditions.
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public string Logic { get; set; }

                }

                /// <summary>
                /// The time when the whitelist rule was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the whitelist rule was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the whitelist rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The UUID of the event.
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// The status of the whitelist rule. Valid values:
                /// 
                /// *   1: enabled
                /// *   0: disabled
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the whitelist rule.
                /// </summary>
                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
