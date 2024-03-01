// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainDnssecInfoResponseBody : TeaModel {
        /// <summary>
        /// The algorithm type. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The digest. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// The digest type. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("DigestType")]
        [Validation(Required=false)]
        public string DigestType { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The delegation signer (DS) record. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("DsRecord")]
        [Validation(Required=false)]
        public string DsRecord { get; set; }

        /// <summary>
        /// The flag. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("Flags")]
        [Validation(Required=false)]
        public string Flags { get; set; }

        /// <summary>
        /// The key tag. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("KeyTag")]
        [Validation(Required=false)]
        public string KeyTag { get; set; }

        /// <summary>
        /// The public key. This parameter is returned if DNSSEC is enabled.
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state of the DNSSEC. Valid values:
        /// 
        /// *   ON
        /// *   OFF
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
