// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSecurityProxyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the NAT firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-nat97ac4d7cc3834a5daf40</para>
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3DC3CAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
