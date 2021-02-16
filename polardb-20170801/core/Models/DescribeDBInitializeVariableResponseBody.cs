// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBInitializeVariableResponseBody : TeaModel {
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public DescribeDBInitializeVariableResponseBodyVariables Variables { get; set; }
        public class DescribeDBInitializeVariableResponseBodyVariables : TeaModel {
            [NameInMap("Variable")]
            [Validation(Required=false)]
            public List<DescribeDBInitializeVariableResponseBodyVariablesVariable> Variable { get; set; }
            public class DescribeDBInitializeVariableResponseBodyVariablesVariable : TeaModel {
                public string Charset { get; set; }
                public string Collate { get; set; }
                public string Ctype { get; set; }
            }
        };

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

    }

}
