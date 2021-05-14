// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSearchConditionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConditionList")]
        [Validation(Required=false)]
        public List<DescribeSearchConditionResponseBodyConditionList> ConditionList { get; set; }
        public class DescribeSearchConditionResponseBodyConditionList : TeaModel {
            [NameInMap("ConditionType")]
            [Validation(Required=false)]
            public string ConditionType { get; set; }

            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("FilterConditions")]
            [Validation(Required=false)]
            public string FilterConditions { get; set; }

        }

    }

}
