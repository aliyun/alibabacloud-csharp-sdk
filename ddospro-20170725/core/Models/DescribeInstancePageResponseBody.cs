// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeInstancePageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeInstancePageResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeInstancePageResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceRemark")]
            [Validation(Required=false)]
            public string InstanceRemark { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<DescribeInstancePageResponseBodyInstanceListIpList> IpList { get; set; }
            public class DescribeInstancePageResponseBodyInstanceListIpList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("BandWidth")]
                [Validation(Required=false)]
                public int? BandWidth { get; set; }

                [NameInMap("ElasticBandWidth")]
                [Validation(Required=false)]
                public int? ElasticBandWidth { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
