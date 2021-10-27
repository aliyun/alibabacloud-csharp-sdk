// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackMenuResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public DescribeBackMenuResponseBodyList List { get; set; }
        public class DescribeBackMenuResponseBodyList : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<DescribeBackMenuResponseBodyListList> List { get; set; }
            public class DescribeBackMenuResponseBodyListList : TeaModel {
                public string MenuName { get; set; }
                public bool? Support { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
