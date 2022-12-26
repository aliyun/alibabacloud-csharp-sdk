// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoNodeResponseBody : TeaModel {
        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeTraceInfoNodeResponseBodyNode Node { get; set; }
        public class DescribeTraceInfoNodeResponseBodyNode : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoNodeResponseBodyNodePropertyList> PropertyList { get; set; }
            public class DescribeTraceInfoNodeResponseBodyNodePropertyList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
