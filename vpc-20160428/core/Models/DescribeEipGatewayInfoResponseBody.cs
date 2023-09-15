// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipGatewayInfoResponseBody : TeaModel {
        /// <summary>
        /// The status code of the operation.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information about the EIP.
        /// </summary>
        [NameInMap("EipInfos")]
        [Validation(Required=false)]
        public DescribeEipGatewayInfoResponseBodyEipInfos EipInfos { get; set; }
        public class DescribeEipGatewayInfoResponseBodyEipInfos : TeaModel {
            [NameInMap("EipInfo")]
            [Validation(Required=false)]
            public List<DescribeEipGatewayInfoResponseBodyEipInfosEipInfo> EipInfo { get; set; }
            public class DescribeEipGatewayInfoResponseBodyEipInfosEipInfo : TeaModel {
                /// <summary>
                /// The IP address of the EIP.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The IP address of the gateway that is associated with the EIP.
                /// </summary>
                [NameInMap("IpGw")]
                [Validation(Required=false)]
                public string IpGw { get; set; }

                /// <summary>
                /// The subnet mask of the EIP.
                /// </summary>
                [NameInMap("IpMask")]
                [Validation(Required=false)]
                public string IpMask { get; set; }

            }

        }

        /// <summary>
        /// The result of the operation.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
