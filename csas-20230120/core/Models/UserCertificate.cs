// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UserCertificate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cert-aabbccdd</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>用于测试</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DnsNames")]
        [Validation(Required=false)]
        public List<string> DnsNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1734492686</para>
        /// </summary>
        [NameInMap("ExpTimeUnix")]
        [Validation(Required=false)]
        public long? ExpTimeUnix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1734523812</para>
        /// </summary>
        [NameInMap("GmtCreateUnix")]
        [Validation(Required=false)]
        public long? GmtCreateUnix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1734523812</para>
        /// </summary>
        [NameInMap("GmtModifiedUnix")]
        [Validation(Required=false)]
        public long? GmtModifiedUnix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>证书1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
