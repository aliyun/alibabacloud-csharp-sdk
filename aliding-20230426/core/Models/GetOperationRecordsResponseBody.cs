// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetOperationRecordsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOperationRecordsResponseBodyResult> Result { get; set; }
        public class GetOperationRecordsResponseBodyResult : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("ActionExit")]
            [Validation(Required=false)]
            public string ActionExit { get; set; }

            [NameInMap("ActiveTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            [NameInMap("DigitalSign")]
            [Validation(Required=false)]
            public string DigitalSign { get; set; }

            [NameInMap("Files")]
            [Validation(Required=false)]
            public string Files { get; set; }

            [NameInMap("OperateTimeGMT")]
            [Validation(Required=false)]
            public string OperateTimeGMT { get; set; }

            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("OperatorDisplayName")]
            [Validation(Required=false)]
            public string OperatorDisplayName { get; set; }

            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("OperatorNickName")]
            [Validation(Required=false)]
            public string OperatorNickName { get; set; }

            [NameInMap("OperatorPhotoUrl")]
            [Validation(Required=false)]
            public string OperatorPhotoUrl { get; set; }

            [NameInMap("OperatorStatus")]
            [Validation(Required=false)]
            public string OperatorStatus { get; set; }

            [NameInMap("OperatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("TaskExecuteType")]
            [Validation(Required=false)]
            public string TaskExecuteType { get; set; }

            [NameInMap("TaskHoldTimeGMT")]
            [Validation(Required=false)]
            public long? TaskHoldTimeGMT { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
