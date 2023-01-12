// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AttachDdosToAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Anti-DDoS Pro/Premium instance that is associated with the GA instance.
        /// </summary>
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        public string DdosId { get; set; }

        /// <summary>
        /// The ID of the GA instance that is associated with the Anti-DDoS Pro/Premium instance.
        /// </summary>
        [NameInMap("GaId")]
        [Validation(Required=false)]
        public string GaId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
