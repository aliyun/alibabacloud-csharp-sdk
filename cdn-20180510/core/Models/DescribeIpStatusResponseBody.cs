// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of the IP addresses of the POPs.
        /// </summary>
        [NameInMap("IpStatus")]
        [Validation(Required=false)]
        public List<DescribeIpStatusResponseBodyIpStatus> IpStatus { get; set; }
        public class DescribeIpStatusResponseBodyIpStatus : TeaModel {
            /// <summary>
            /// The IP address of the POP.
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The status.
            /// 
            /// *   **nonali**: not an Alibaba Cloud CDN POP
            /// *   **normal**: an available Alibaba Cloud CDN POP
            /// *   **abnormal**: an unavailable Alibaba Cloud CDN POP
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
