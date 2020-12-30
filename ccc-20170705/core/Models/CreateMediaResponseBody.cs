// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateMediaResponseBody : TeaModel {
        [NameInMap("MediaUploadParam")]
        [Validation(Required=false)]
        public CreateMediaResponseBodyMediaUploadParam MediaUploadParam { get; set; }
        public class CreateMediaResponseBodyMediaUploadParam : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }
            [NameInMap("OssFilePath")]
            [Validation(Required=false)]
            public string OssFilePath { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
