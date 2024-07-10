// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class CreateTextFileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTextFileResponseBodyData Data { get; set; }
        public class CreateTextFileResponseBodyData : TeaModel {
            [NameInMap("TextFileId")]
            [Validation(Required=false)]
            public string TextFileId { get; set; }

            [NameInMap("TextFileName")]
            [Validation(Required=false)]
            public string TextFileName { get; set; }

            [NameInMap("TextFileUrl")]
            [Validation(Required=false)]
            public string TextFileUrl { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
