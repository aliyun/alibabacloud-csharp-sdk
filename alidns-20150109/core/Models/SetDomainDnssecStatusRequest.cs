// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDomainDnssecStatusRequest : TeaModel {
        /// <summary>
        /// The domain name for which you want to set the DNSSEC status.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The DNSSEC status. Valid values:
        /// 
        /// *   ON: enables DNSSEC for the domain name.
        /// *   OFF: disables DNSSEC for the domain name.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
