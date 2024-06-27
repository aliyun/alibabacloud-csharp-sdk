// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperatorListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeOperatorListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeOperatorListResponseBodyResultObject : TeaModel {
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("operators")]
            [Validation(Required=false)]
            public List<DescribeOperatorListResponseBodyResultObjectOperators> Operators { get; set; }
            public class DescribeOperatorListResponseBodyResultObjectOperators : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("hasRightVariable")]
                [Validation(Required=false)]
                public bool? HasRightVariable { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("rightVariables")]
                [Validation(Required=false)]
                public List<DescribeOperatorListResponseBodyResultObjectOperatorsRightVariables> RightVariables { get; set; }
                public class DescribeOperatorListResponseBodyResultObjectOperatorsRightVariables : TeaModel {
                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("fieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                    [NameInMap("fieldValue")]
                    [Validation(Required=false)]
                    public string FieldValue { get; set; }

                }

            }

        }

    }

}
