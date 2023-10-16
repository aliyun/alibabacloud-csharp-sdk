// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QuerySupplementDetailResponseBody : TeaModel {
        [NameInMap("AcceptDeadTime")]
        [Validation(Required=false)]
        public long? AcceptDeadTime { get; set; }

        [NameInMap("AcceptTime")]
        [Validation(Required=false)]
        public long? AcceptTime { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileTemplateUrls")]
        [Validation(Required=false)]
        public QuerySupplementDetailResponseBodyFileTemplateUrls FileTemplateUrls { get; set; }
        public class QuerySupplementDetailResponseBodyFileTemplateUrls : TeaModel {
            [NameInMap("FileTemplateUrls")]
            [Validation(Required=false)]
            public List<string> FileTemplateUrls { get; set; }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("OperateTime")]
        [Validation(Required=false)]
        public long? OperateTime { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SbjDeadTime")]
        [Validation(Required=false)]
        public long? SbjDeadTime { get; set; }

        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public long? SendTime { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("UploadFileTemplateUrl")]
        [Validation(Required=false)]
        public string UploadFileTemplateUrl { get; set; }

    }

}
