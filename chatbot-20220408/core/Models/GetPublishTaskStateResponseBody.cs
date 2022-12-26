// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetPublishTaskStateResponseBody : TeaModel {
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        [NameInMap("Errors")]
        [Validation(Required=false)]
        public Dictionary<string, object> Errors { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Warnings { get; set; }

    }

}
