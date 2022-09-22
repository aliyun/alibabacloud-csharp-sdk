// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeEniQosGroupInfoResponseBody : TeaModel {
        [NameInMap("QosGroupInfo")]
        [Validation(Required=false)]
        public DescribeEniQosGroupInfoResponseBodyQosGroupInfo QosGroupInfo { get; set; }
        public class DescribeEniQosGroupInfoResponseBodyQosGroupInfo : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NetworkInterfaceIds")]
            [Validation(Required=false)]
            public DescribeEniQosGroupInfoResponseBodyQosGroupInfoNetworkInterfaceIds NetworkInterfaceIds { get; set; }
            public class DescribeEniQosGroupInfoResponseBodyQosGroupInfoNetworkInterfaceIds : TeaModel {
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public List<string> NetworkInterfaceId { get; set; }

            }

            [NameInMap("QosGroup")]
            [Validation(Required=false)]
            public DescribeEniQosGroupInfoResponseBodyQosGroupInfoQosGroup QosGroup { get; set; }
            public class DescribeEniQosGroupInfoResponseBodyQosGroupInfoQosGroup : TeaModel {
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("QosGroupName")]
                [Validation(Required=false)]
                public string QosGroupName { get; set; }

                [NameInMap("Rx")]
                [Validation(Required=false)]
                public string Rx { get; set; }

                [NameInMap("RxPps")]
                [Validation(Required=false)]
                public string RxPps { get; set; }

                [NameInMap("Tx")]
                [Validation(Required=false)]
                public string Tx { get; set; }

                [NameInMap("TxPps")]
                [Validation(Required=false)]
                public string TxPps { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
