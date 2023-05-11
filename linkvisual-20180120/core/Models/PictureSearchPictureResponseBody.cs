// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class PictureSearchPictureResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PictureSearchPictureResponseBodyData Data { get; set; }
        public class PictureSearchPictureResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<PictureSearchPictureResponseBodyDataPageData> PageData { get; set; }
            public class PictureSearchPictureResponseBodyDataPageData : TeaModel {
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                [NameInMap("GatewayIotId")]
                [Validation(Required=false)]
                public string GatewayIotId { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

                [NameInMap("VectorId")]
                [Validation(Required=false)]
                public string VectorId { get; set; }

                [NameInMap("VectorType")]
                [Validation(Required=false)]
                public int? VectorType { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
