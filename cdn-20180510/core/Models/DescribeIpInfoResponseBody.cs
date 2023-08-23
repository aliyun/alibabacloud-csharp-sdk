// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpInfoResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the IP address belongs to an Alibaba Cloud CDN POP.
        /// *   **True**:Yes.
        /// *   **False**:No.
        /// </summary>
        [NameInMap("CdnIp")]
        [Validation(Required=false)]
        public string CdnIp { get; set; }

        /// <summary>
        /// The name of the ISP in Chinese.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The name of the ISP.
        /// </summary>
        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        /// <summary>
        /// The name of the region in Chinese.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The name of the region.
        /// </summary>
        [NameInMap("RegionEname")]
        [Validation(Required=false)]
        public string RegionEname { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
