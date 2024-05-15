// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribePackIpListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code of the request.
        /// 
        /// For more information about status codes, see [Common parameters](https://help.aliyun.com/document_detail/118841.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The IP addresses that are protected by the instance.
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<DescribePackIpListResponseBodyIpList> IpList { get; set; }
        public class DescribePackIpListResponseBodyIpList : TeaModel {
            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The ID of the member.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            [NameInMap("NsmExpireAt")]
            [Validation(Required=false)]
            public long? NsmExpireAt { get; set; }

            [NameInMap("NsmStartAt")]
            [Validation(Required=false)]
            public long? NsmStartAt { get; set; }

            [NameInMap("NsmStatus")]
            [Validation(Required=false)]
            public int? NsmStatus { get; set; }

            /// <summary>
            /// The type of the cloud asset to which the IP address belongs. Valid values:
            /// 
            /// *   **ECS**: an ECS instance.
            /// *   **SLB**: a CLB instance, originally called an SLB instance.
            /// *   **EIP**: an EIP. If the IP address belongs to an ALB instance, the value EIP is returned.
            /// *   **WAF**: a WAF instance.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The region to which the protected IP address belongs.
            /// 
            /// >  If the protected IP address is in the same region as the instance, this parameter is not returned.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The description of the cloud asset to which the IP address belongs. The asset can be an ECS instance or an SLB instance.
            /// 
            /// >  If no descriptions are provided for the asset, this parameter is not returned.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the IP address. Valid values:
            /// 
            /// *   **normal**: The IP address is in the normal state, which indicates that the IP address is not under attack.
            /// *   **hole_begin**: Blackhole filtering is triggered for the IP address.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The call is successful.
        /// *   **false**: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of protected IP addresses.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
