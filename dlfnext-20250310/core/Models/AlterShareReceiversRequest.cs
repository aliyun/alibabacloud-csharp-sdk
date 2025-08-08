// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterShareReceiversRequest : TeaModel {
        [NameInMap("addedReceivers")]
        [Validation(Required=false)]
        public List<string> AddedReceivers { get; set; }

        [NameInMap("removedReceivers")]
        [Validation(Required=false)]
        public List<string> RemovedReceivers { get; set; }

    }

}
