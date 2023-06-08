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
        /// 
        /// *   **True**
        /// *   **False**
        /// </summary>
        [NameInMap("CdnIp")]
        [Validation(Required=false)]
        public string CdnIp { get; set; }

        /// <summary>
        /// The Chinese name of the ISP.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The English name of the Internet service provider (ISP).
        /// </summary>
        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        /// <summary>
        /// The Chinese name of the region.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The English name of the region.
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
