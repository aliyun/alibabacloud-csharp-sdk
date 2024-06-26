// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ResetAntChainUserCertificateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public int? Operation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
