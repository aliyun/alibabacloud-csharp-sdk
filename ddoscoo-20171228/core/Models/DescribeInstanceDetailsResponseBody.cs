// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceDetailsResponseBody : TeaModel {
        [NameInMap("InstanceDetails")]
        [Validation(Required=false)]
        public List<DescribeInstanceDetailsResponseBodyInstanceDetails> InstanceDetails { get; set; }
        public class DescribeInstanceDetailsResponseBodyInstanceDetails : TeaModel {
            [NameInMap("EipInfoList")]
            [Validation(Required=false)]
            public List<DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfoList> EipInfoList { get; set; }
            public class DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfoList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

            }

            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
