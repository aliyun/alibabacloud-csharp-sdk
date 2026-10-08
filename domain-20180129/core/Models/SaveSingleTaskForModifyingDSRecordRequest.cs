// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForModifyingDSRecordRequest : TeaModel {
        /// <summary>
        /// <para>Encryption algorithm number. For more information, see <a href="https://www.iana.org/assignments/dns-sec-alg-numbers/dns-sec-alg-numbers.xhtml">Domain Name System Security (DNSSEC) Algorithm Numbers</a>. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: RSA/MD5  </description></item>
        /// <item><description><b>2</b>: Diffie-Hellman  </description></item>
        /// <item><description><b>3</b>: DSA/SHA-1  </description></item>
        /// <item><description><b>5</b>: RSA/SHA-1  </description></item>
        /// <item><description><b>6</b>: DSA-NSEC3-SHA1  </description></item>
        /// <item><description><b>7</b>: RSASHA1-NSEC3-SHA1  </description></item>
        /// <item><description><b>8</b>: RSA/SHA-256  </description></item>
        /// <item><description><b>10</b>: RSA/SHA-512  </description></item>
        /// <item><description><b>12</b>: GOST R 34.10-2001  </description></item>
        /// <item><description><b>13</b>: ECDSA Curve P-256 with SHA-256  </description></item>
        /// <item><description><b>14</b>: ECDSA Curve P-384 with SHA-384  </description></item>
        /// <item><description><b>15</b>: Ed2551916 Ed448  </description></item>
        /// <item><description><b>252</b>: Reserved for Indirect Keys  </description></item>
        /// <item><description><b>253</b>: private algorithm  </description></item>
        /// <item><description><b>254</b>: private algorithm OID</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public int? Algorithm { get; set; }

        /// <summary>
        /// <para>Summary value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f58fa917424383934c7b0cf1a90f61d692745680fa06f5ecdbe0924e86de9598</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>Digest algorithm type. For more information, see <a href="https://www.iana.org/assignments/ds-rr-types/ds-rr-types.xhtml">Delegation Signer (DS) Resource Record (RR) Type Digest Algorithms</a>. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: SHA-1  </description></item>
        /// <item><description><b>2</b>: SHA-256  </description></item>
        /// <item><description><b>3</b>: GOST R 34.11-94  </description></item>
        /// <item><description><b>4</b>: SHA-384</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DigestType")]
        [Validation(Required=false)]
        public int? DigestType { get; set; }

        /// <summary>
        /// <para>Domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Key tag used to identify DNSSEC records. It is an integer less than 65536.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KeyTag")]
        [Validation(Required=false)]
        public int? KeyTag { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese  </description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
