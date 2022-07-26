// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyForwardEntryRequest : TeaModel {
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

    }

}
