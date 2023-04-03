// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class GetTxtRecordForVerifyRequest : TeaModel {
        /// <summary>
        /// The domain name.
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
        /// The function verified by using the TXT record. Valid values:
        /// 
        /// *   ADD_SUBDOMAIN
        /// *   RETRIEVAL
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
