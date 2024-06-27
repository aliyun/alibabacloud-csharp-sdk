// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeExpressionVariableFunctionListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeExpressionVariableFunctionListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeExpressionVariableFunctionListResponseBodyResultObject : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("maxParamSize")]
            [Validation(Required=false)]
            public long? MaxParamSize { get; set; }

            [NameInMap("minParamSize")]
            [Validation(Required=false)]
            public long? MinParamSize { get; set; }

            [NameInMap("paramTypes")]
            [Validation(Required=false)]
            public string ParamTypes { get; set; }

            [NameInMap("redirect")]
            [Validation(Required=false)]
            public bool? Redirect { get; set; }

            [NameInMap("returnTypes")]
            [Validation(Required=false)]
            public string ReturnTypes { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
