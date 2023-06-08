// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpInfoResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the specified IP address is assigned to an Alibaba Cloud DCDN POP.
        /// 
        /// *   True
        /// *   False
        /// </summary>
        [NameInMap("DcdnIp")]
        [Validation(Required=false)]
        public string DcdnIp { get; set; }

        /// <summary>
        /// The ISP to which the specified IP address belongs.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The name of the Internet service provider (ISP).
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
