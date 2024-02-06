// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyForwardEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the DNAT entry.
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// The name of the DNAT entry. The name must be 2 to 128 characters in length. It cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// The probe port. The port must be within the internal port range. By default, this parameter is left empty.
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

    }

}
