// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ChatappBindWabaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChatappBindWabaResponseBodyData Data { get; set; }
        public class ChatappBindWabaResponseBodyData : TeaModel {
            [NameInMap("CustSpaceId")]
            [Validation(Required=false)]
            public string CustSpaceId { get; set; }

            /// <summary>
            /// wabaId
            /// </summary>
            [NameInMap("WabaId")]
            [Validation(Required=false)]
            public string WabaId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
