// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class CreateAlertTemplateResponseBody : TeaModel {
        [NameInMap("AlertTemplate")]
        [Validation(Required=false)]
        public CreateAlertTemplateResponseBodyAlertTemplate AlertTemplate { get; set; }
        public class CreateAlertTemplateResponseBodyAlertTemplate : TeaModel {
            [NameInMap("AlertProvider")]
            [Validation(Required=false)]
            public string AlertProvider { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public Dictionary<string, object> Annotations { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("LabelMatchExpressionGrid")]
            [Validation(Required=false)]
            public CreateAlertTemplateResponseBodyAlertTemplateLabelMatchExpressionGrid LabelMatchExpressionGrid { get; set; }
            public class CreateAlertTemplateResponseBodyAlertTemplateLabelMatchExpressionGrid : TeaModel {
                [NameInMap("LabelMatchExpressionGroups")]
                [Validation(Required=false)]
                public List<CreateAlertTemplateResponseBodyAlertTemplateLabelMatchExpressionGridLabelMatchExpressionGroups> LabelMatchExpressionGroups { get; set; }
                public class CreateAlertTemplateResponseBodyAlertTemplateLabelMatchExpressionGridLabelMatchExpressionGroups : TeaModel {
                    [NameInMap("LabelMatchExpressions")]
                    [Validation(Required=false)]
                    public List<CreateAlertTemplateResponseBodyAlertTemplateLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions> LabelMatchExpressions { get; set; }
                    public class CreateAlertTemplateResponseBodyAlertTemplateLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, object> Labels { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public int? ParentId { get; set; }

            [NameInMap("Public")]
            [Validation(Required=false)]
            public bool? Public { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            [NameInMap("TemplateProvider")]
            [Validation(Required=false)]
            public string TemplateProvider { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
