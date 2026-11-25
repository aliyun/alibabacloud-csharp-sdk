// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddDeviceBelongIdentifiersResponseBody : TeaModel {
        [NameInMap("IdentifierIds")]
        [Validation(Required=false)]
        public List<string> IdentifierIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
