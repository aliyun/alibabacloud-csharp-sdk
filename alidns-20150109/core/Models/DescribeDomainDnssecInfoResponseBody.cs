// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainDnssecInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The algorithm type. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The digest. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1A0424B97A049F1F9B2EA139CC298533219668164E343BD21203ABC4608C02A</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The digest type. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHA256</para>
        /// </summary>
        [NameInMap("DigestType")]
        [Validation(Required=false)]
        public string DigestType { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The delegation signer (DS) record. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com. 3600 IN DS 2371 13 2 C1A0424B97A049F1F9B2EA139CC298533219668164E343BD21203ABC4608C02A</para>
        /// </summary>
        [NameInMap("DsRecord")]
        [Validation(Required=false)]
        public string DsRecord { get; set; }

        /// <summary>
        /// <para>The flag. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>257 (KSK)</para>
        /// </summary>
        [NameInMap("Flags")]
        [Validation(Required=false)]
        public string Flags { get; set; }

        /// <summary>
        /// <para>The key tag. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54931</para>
        /// </summary>
        [NameInMap("KeyTag")]
        [Validation(Required=false)]
        public string KeyTag { get; set; }

        /// <summary>
        /// <para>The public key. This parameter is returned if DNSSEC is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mdsswUyr3DPW132mOi8V9xESWE8jTo0dxCjjnopKl+GqJxpVXckHAeF+KkxLbxILfDLUT0rAK9iUzy1L53eKGQ==</para>
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state of the DNSSEC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ON</description></item>
        /// <item><description>OFF</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
