// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstancesRequest : TeaModel {
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **100**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// The version code of the Alibaba Cloud DNS instance.
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
