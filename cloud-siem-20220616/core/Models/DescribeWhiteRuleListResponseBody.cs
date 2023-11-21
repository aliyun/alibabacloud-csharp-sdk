// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeWhiteRuleListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWhiteRuleListResponseBodyData Data { get; set; }
        public class DescribeWhiteRuleListResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeWhiteRuleListResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeWhiteRuleListResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeWhiteRuleListResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeWhiteRuleListResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("AlertNameId")]
                [Validation(Required=false)]
                public string AlertNameId { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("AlertTypeId")]
                [Validation(Required=false)]
                public string AlertTypeId { get; set; }

                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public DescribeWhiteRuleListResponseBodyDataResponseDataExpression Expression { get; set; }
                public class DescribeWhiteRuleListResponseBodyDataResponseDataExpression : TeaModel {
                    [NameInMap("Conditions")]
                    [Validation(Required=false)]
                    public List<DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditions> Conditions { get; set; }
                    public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditions : TeaModel {
                        [NameInMap("IsNot")]
                        [Validation(Required=false)]
                        public bool? IsNot { get; set; }

                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public int? ItemId { get; set; }

                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsLeft Left { get; set; }
                        public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsLeft : TeaModel {
                            [NameInMap("IsVar")]
                            [Validation(Required=false)]
                            public bool? IsVar { get; set; }

                            [NameInMap("Modifier")]
                            [Validation(Required=false)]
                            public string Modifier { get; set; }

                            [NameInMap("ModifierParam")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ModifierParam { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Right")]
                        [Validation(Required=false)]
                        public DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsRight Right { get; set; }
                        public class DescribeWhiteRuleListResponseBodyDataResponseDataExpressionConditionsRight : TeaModel {
                            [NameInMap("IsVar")]
                            [Validation(Required=false)]
                            public bool? IsVar { get; set; }

                            [NameInMap("Modifier")]
                            [Validation(Required=false)]
                            public string Modifier { get; set; }

                            [NameInMap("ModifierParam")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ModifierParam { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public string Logic { get; set; }

                }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
