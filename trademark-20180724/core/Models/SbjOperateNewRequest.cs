// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SbjOperateNewRequest : TeaModel {
        [NameInMap("AddSubmitCount")]
        [Validation(Required=false)]
        public bool? AddSubmitCount { get; set; }

        [NameInMap("AllowResubmit")]
        [Validation(Required=false)]
        public bool? AllowResubmit { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        [NameInMap("ApplyNo")]
        [Validation(Required=false)]
        public string ApplyNo { get; set; }

        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public bool? AuditStatus { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ChangeStatus")]
        [Validation(Required=false)]
        public bool? ChangeStatus { get; set; }

        [NameInMap("ErrorMsgScreenshot")]
        [Validation(Required=false)]
        public string ErrorMsgScreenshot { get; set; }

        [NameInMap("FileDate")]
        [Validation(Required=false)]
        public string FileDate { get; set; }

        [NameInMap("FileOssKey")]
        [Validation(Required=false)]
        public string FileOssKey { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("OrderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("ReceiptOssKey")]
        [Validation(Required=false)]
        public string ReceiptOssKey { get; set; }

        [NameInMap("SubmittedSuccess")]
        [Validation(Required=false)]
        public bool? SubmittedSuccess { get; set; }

        [NameInMap("SuccessType")]
        [Validation(Required=false)]
        public string SuccessType { get; set; }

    }

}
