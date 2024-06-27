// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeQueryVariableDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeQueryVariableDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeQueryVariableDetailResponseBodyResultObject : TeaModel {
            [NameInMap("dataSourceCode")]
            [Validation(Required=false)]
            public long? DataSourceCode { get; set; }

            [NameInMap("dataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("expressionTitle")]
            [Validation(Required=false)]
            public string ExpressionTitle { get; set; }

            [NameInMap("expressionVariable")]
            [Validation(Required=false)]
            public string ExpressionVariable { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("outlier")]
            [Validation(Required=false)]
            public string Outlier { get; set; }

            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
