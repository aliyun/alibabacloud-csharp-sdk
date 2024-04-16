// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnInfoResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SensitiveColumnList")]
        [Validation(Required=false)]
        public ListSensitiveColumnInfoResponseBodySensitiveColumnList SensitiveColumnList { get; set; }
        public class ListSensitiveColumnInfoResponseBodySensitiveColumnList : TeaModel {
            [NameInMap("SensitiveColumn")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumn> SensitiveColumn { get; set; }
            public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumn : TeaModel {
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("DefaultDesensitizationRule")]
                [Validation(Required=false)]
                public ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnDefaultDesensitizationRule DefaultDesensitizationRule { get; set; }
                public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnDefaultDesensitizationRule : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                [NameInMap("IsPlain")]
                [Validation(Required=false)]
                public bool? IsPlain { get; set; }

                [NameInMap("SampleData")]
                [Validation(Required=false)]
                public string SampleData { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                [NameInMap("SemiDesensitizationRuleList")]
                [Validation(Required=false)]
                public ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleList SemiDesensitizationRuleList { get; set; }
                public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleList : TeaModel {
                    [NameInMap("SemiDesensitizationRule")]
                    [Validation(Required=false)]
                    public List<ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleListSemiDesensitizationRule> SemiDesensitizationRule { get; set; }
                    public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleListSemiDesensitizationRule : TeaModel {
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public long? RuleId { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("UserSensitivityLevel")]
                [Validation(Required=false)]
                public string UserSensitivityLevel { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
