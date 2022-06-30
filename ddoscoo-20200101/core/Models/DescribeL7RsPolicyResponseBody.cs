// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7RsPolicyResponseBody : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<DescribeL7RsPolicyResponseBodyAttributes> Attributes { get; set; }
        public class DescribeL7RsPolicyResponseBodyAttributes : TeaModel {
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public DescribeL7RsPolicyResponseBodyAttributesAttribute Attribute { get; set; }
            public class DescribeL7RsPolicyResponseBodyAttributesAttribute : TeaModel {
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }
            };

            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

            [NameInMap("RsType")]
            [Validation(Required=false)]
            public int? RsType { get; set; }

        }

        [NameInMap("ProxyMode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
