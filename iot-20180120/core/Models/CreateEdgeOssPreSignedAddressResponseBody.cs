// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeOssPreSignedAddressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEdgeOssPreSignedAddressResponseBodyData Data { get; set; }
        public class CreateEdgeOssPreSignedAddressResponseBodyData : TeaModel {
            [NameInMap("OssAddress")]
            [Validation(Required=false)]
            public string OssAddress { get; set; }

            [NameInMap("OssPreSignedAddress")]
            [Validation(Required=false)]
            public string OssPreSignedAddress { get; set; }

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
