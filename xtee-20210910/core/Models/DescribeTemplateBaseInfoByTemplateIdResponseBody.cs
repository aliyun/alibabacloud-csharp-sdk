// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTemplateBaseInfoByTemplateIdResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeTemplateBaseInfoByTemplateIdResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTemplateBaseInfoByTemplateIdResponseBodyResultObject : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("eventStauts")]
            [Validation(Required=false)]
            public string EventStauts { get; set; }

            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<DescribeTemplateBaseInfoByTemplateIdResponseBodyResultObjectInputFields> InputFields { get; set; }
            public class DescribeTemplateBaseInfoByTemplateIdResponseBodyResultObjectInputFields : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public string FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("ruleDetails")]
            [Validation(Required=false)]
            public List<DescribeTemplateBaseInfoByTemplateIdResponseBodyResultObjectRuleDetails> RuleDetails { get; set; }
            public class DescribeTemplateBaseInfoByTemplateIdResponseBodyResultObjectRuleDetails : TeaModel {
                [NameInMap("logicExpression")]
                [Validation(Required=false)]
                public string LogicExpression { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("ruleActions")]
                [Validation(Required=false)]
                public string RuleActions { get; set; }

                [NameInMap("ruleExpressions")]
                [Validation(Required=false)]
                public string RuleExpressions { get; set; }

                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("ruleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

            }

            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
