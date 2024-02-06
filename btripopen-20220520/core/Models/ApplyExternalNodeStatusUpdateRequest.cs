// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyExternalNodeStatusUpdateRequest : TeaModel {
        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("operation_records")]
        [Validation(Required=false)]
        public List<ApplyExternalNodeStatusUpdateRequestOperationRecords> OperationRecords { get; set; }
        public class ApplyExternalNodeStatusUpdateRequestOperationRecords : TeaModel {
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("operate_time")]
            [Validation(Required=false)]
            public string OperateTime { get; set; }

            [NameInMap("operator_name")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("process_action_result")]
        [Validation(Required=false)]
        public string ProcessActionResult { get; set; }

    }

}
