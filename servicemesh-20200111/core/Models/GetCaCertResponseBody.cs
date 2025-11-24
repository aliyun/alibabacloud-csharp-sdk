// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetCaCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded content of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\nMIIFszCCA5ugAwIBAgIDM/1OMA0GCSqGSIb3DQEBCwUAME427zhT4HDLcCEW****-----END CERTIFICATE-----\n</para>
        /// </summary>
        [NameInMap("CaCert")]
        [Validation(Required=false)]
        public string CaCert { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0496204-7586-5B4C-B364-2361CC0ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
