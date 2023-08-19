// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class VerifyVodDomainOwnerRequest : TeaModel {
        /// <summary>
        /// The domain name of which you want to verify the ownership. You can specify only one domain name in each call.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The DNS verification method that is used to verify the ownership of the specified domain name.
        /// </summary>
        [NameInMap("VerifyType")]
        [Validation(Required=false)]
        public string VerifyType { get; set; }

    }

}
