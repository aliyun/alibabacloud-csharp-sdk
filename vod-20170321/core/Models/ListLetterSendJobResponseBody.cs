// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListLetterSendJobResponseBody : TeaModel {
        [NameInMap("LetterJobList")]
        [Validation(Required=false)]
        public List<ListLetterSendJobResponseBodyLetterJobList> LetterJobList { get; set; }
        public class ListLetterSendJobResponseBodyLetterJobList : TeaModel {
            [NameInMap("BccAddress")]
            [Validation(Required=false)]
            public string BccAddress { get; set; }

            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            [NameInMap("CcAddress")]
            [Validation(Required=false)]
            public string CcAddress { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DetectionId")]
            [Validation(Required=false)]
            public string DetectionId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("ToAddress")]
            [Validation(Required=false)]
            public string ToAddress { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
