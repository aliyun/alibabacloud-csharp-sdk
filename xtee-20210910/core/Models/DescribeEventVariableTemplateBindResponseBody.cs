// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableTemplateBindResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeEventVariableTemplateBindResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventVariableTemplateBindResponseBodyResultObject : TeaModel {
            [NameInMap("chargeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableTemplateBindResponseBodyResultObjectChargeVariables> ChargeVariables { get; set; }
            public class DescribeEventVariableTemplateBindResponseBodyResultObjectChargeVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("freeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableTemplateBindResponseBodyResultObjectFreeVariables> FreeVariables { get; set; }
            public class DescribeEventVariableTemplateBindResponseBodyResultObjectFreeVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

    }

}
