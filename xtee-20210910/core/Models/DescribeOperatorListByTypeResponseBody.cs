// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperatorListByTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeOperatorListByTypeResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeOperatorListByTypeResponseBodyResultObject : TeaModel {
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("operators")]
            [Validation(Required=false)]
            public List<DescribeOperatorListByTypeResponseBodyResultObjectOperators> Operators { get; set; }
            public class DescribeOperatorListByTypeResponseBodyResultObjectOperators : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("hasRightVariable")]
                [Validation(Required=false)]
                public bool? HasRightVariable { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
