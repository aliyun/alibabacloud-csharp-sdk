// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBIpWhiteListResponseBody : TeaModel {
        /// <summary>
        /// The IP address whitelist.
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public DescribeDrdsDBIpWhiteListResponseBodyIpWhiteList IpWhiteList { get; set; }
        public class DescribeDrdsDBIpWhiteListResponseBodyIpWhiteList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
