// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVodDomainRequest : TeaModel {
        /// <summary>
        /// The domain name for CDN.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The information about the address of the origin server.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// The top-level domain name.
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
