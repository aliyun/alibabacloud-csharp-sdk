// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePickUpWaybillResponseBodyData Data { get; set; }
        public class CreatePickUpWaybillResponseBodyData : TeaModel {
            [NameInMap("CpCode")]
            [Validation(Required=false)]
            public string CpCode { get; set; }
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }
            [NameInMap("GotCode")]
            [Validation(Required=false)]
            public string GotCode { get; set; }
            [NameInMap("MailNo")]
            [Validation(Required=false)]
            public string MailNo { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
