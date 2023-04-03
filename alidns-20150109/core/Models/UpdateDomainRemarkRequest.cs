// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDomainRemarkRequest : TeaModel {
        /// <summary>
        /// The domain name in Alibaba Cloud DNS.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The description of your domain name.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
