// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class CreateCorpNumberGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCorpNumberGroupResponseBodyData Data { get; set; }
        public class CreateCorpNumberGroupResponseBodyData : TeaModel {
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("NumberCount")]
            [Validation(Required=false)]
            public string NumberCount { get; set; }

            [NameInMap("NumberGroupId")]
            [Validation(Required=false)]
            public string NumberGroupId { get; set; }

            [NameInMap("NumberGroupName")]
            [Validation(Required=false)]
            public string NumberGroupName { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
