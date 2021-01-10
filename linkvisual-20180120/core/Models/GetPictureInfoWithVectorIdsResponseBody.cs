// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetPictureInfoWithVectorIdsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPictureInfoWithVectorIdsResponseBodyData> Data { get; set; }
        public class GetPictureInfoWithVectorIdsResponseBodyData : TeaModel {
            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            [NameInMap("GatewayIotId")]
            [Validation(Required=false)]
            public string GatewayIotId { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
