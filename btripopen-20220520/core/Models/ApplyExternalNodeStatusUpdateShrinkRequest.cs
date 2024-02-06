// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyExternalNodeStatusUpdateShrinkRequest : TeaModel {
        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("operation_records")]
        [Validation(Required=false)]
        public string OperationRecordsShrink { get; set; }

        [NameInMap("process_action_result")]
        [Validation(Required=false)]
        public string ProcessActionResult { get; set; }

    }

}
