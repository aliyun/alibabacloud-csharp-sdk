// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DeleteCostUnitRequest : TeaModel {
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

        [NameInMap("UnitId")]
        [Validation(Required=false)]
        public long? UnitId { get; set; }

    }

}
