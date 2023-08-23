// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScanCodeBindResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ScanCodeBindResponseBodyResult Result { get; set; }
        public class ScanCodeBindResponseBodyResult : TeaModel {
            [NameInMap("BizGroup")]
            [Validation(Required=false)]
            public string BizGroup { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// A963*0158
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            /// <summary>
            /// DAFE****ce3ej=
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

    }

}
