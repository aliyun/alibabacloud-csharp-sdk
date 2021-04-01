// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceDetailsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceDetails")]
        [Validation(Required=true)]
        public List<DescribeInstanceDetailsResponseInstanceDetails> InstanceDetails { get; set; }
        public class DescribeInstanceDetailsResponseInstanceDetails : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Line")]
            [Validation(Required=true)]
            public string Line { get; set; }

            [NameInMap("EipInfoList")]
            [Validation(Required=true)]
            public List<DescribeInstanceDetailsResponseInstanceDetailsEipInfoList> EipInfoList { get; set; }
            public class DescribeInstanceDetailsResponseInstanceDetailsEipInfoList : TeaModel {
                [NameInMap("Eip")]
                [Validation(Required=true)]
                public string Eip { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

            }

        }

    }

}
