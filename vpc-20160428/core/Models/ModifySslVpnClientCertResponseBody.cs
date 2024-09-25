// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifySslVpnClientCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert2</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>606998F0-B94D-48FE-8316-ACA81BB230DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-bp1n8wcf134yl0osr****</para>
        /// </summary>
        [NameInMap("SslVpnClientCertId")]
        [Validation(Required=false)]
        public string SslVpnClientCertId { get; set; }

    }

}
