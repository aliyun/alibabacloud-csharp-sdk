// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSslVpnClientCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SslVpnClientCert</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>079874CD-AEC1-43E6-AC03-ADD96B6E4907</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-m5euof6s5jy8vs5kd****</para>
        /// </summary>
        [NameInMap("SslVpnClientCertId")]
        [Validation(Required=false)]
        public string SslVpnClientCertId { get; set; }

    }

}
