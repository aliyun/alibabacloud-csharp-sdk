// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateUploadConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateUploadConfigResponseBodyData Data { get; set; }
        public class GenerateUploadConfigResponseBodyData : TeaModel {
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            [NameInMap("FormDatas")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormDatas { get; set; }

            [NameInMap("PostUrl")]
            [Validation(Required=false)]
            public string PostUrl { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
