// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryDevicePictureFileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicePictureFileResponseBodyData Data { get; set; }
        public class QueryDevicePictureFileResponseBodyData : TeaModel {
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("PicCreateTime")]
            [Validation(Required=false)]
            public long? PicCreateTime { get; set; }

            [NameInMap("PicId")]
            [Validation(Required=false)]
            public string PicId { get; set; }

            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

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
