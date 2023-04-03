// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDNSSLBWeightRequest : TeaModel {
        /// <summary>
        /// The language of the domain name.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the DNS record.
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// The IP address of the client that you use to change the weight.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// The updated weight of the DNS record. Valid values: `1 to 100`.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
