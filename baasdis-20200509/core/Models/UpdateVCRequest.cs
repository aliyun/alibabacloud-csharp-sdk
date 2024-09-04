// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BaasDis20200509.Models
{
    public class UpdateVCRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IssuerDid")]
        [Validation(Required=false)]
        public string IssuerDid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VCId")]
        [Validation(Required=false)]
        public string VCId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VCStatus")]
        [Validation(Required=false)]
        public string VCStatus { get; set; }

    }

}
