// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class RevokeWHClientCertificateRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the client certificate or server certificate that you want to revoke.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
