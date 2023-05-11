// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryDeviceVodUrlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceVodUrlResponseBodyData Data { get; set; }
        public class QueryDeviceVodUrlResponseBodyData : TeaModel {
            [NameInMap("DecryptKey")]
            [Validation(Required=false)]
            public string DecryptKey { get; set; }

            [NameInMap("StunInfo")]
            [Validation(Required=false)]
            public string StunInfo { get; set; }

            [NameInMap("VodUrl")]
            [Validation(Required=false)]
            public string VodUrl { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
