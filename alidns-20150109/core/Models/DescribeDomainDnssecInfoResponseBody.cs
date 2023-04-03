// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainDnssecInfoResponseBody : TeaModel {
        /// <summary>
        /// The algorithm configured in a DNSSEC record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The digest configured in a DNSSEC record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// The digest type configured in a DNSSEC record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("DigestType")]
        [Validation(Required=false)]
        public string DigestType { get; set; }

        /// <summary>
        /// The domain name that is queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The DS record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("DsRecord")]
        [Validation(Required=false)]
        public string DsRecord { get; set; }

        /// <summary>
        /// The flag of a DNSSEC record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("Flags")]
        [Validation(Required=false)]
        public string Flags { get; set; }

        /// <summary>
        /// The key tag of a DNSSEC record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("KeyTag")]
        [Validation(Required=false)]
        public string KeyTag { get; set; }

        /// <summary>
        /// The public key for a DNSSEC record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether DNSSEC is enabled for the specified domain name.
        /// 
        /// *   ON: DNSSEC is enabled.
        /// *   OFF: DNSSEC is disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
