// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeGeneralStructureResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeGeneralStructureResponseBodyData Data { get; set; }
        public class RecognizeGeneralStructureResponseBodyData : TeaModel {
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("SubImageCount")]
            [Validation(Required=false)]
            public int? SubImageCount { get; set; }

            [NameInMap("SubImages")]
            [Validation(Required=false)]
            public List<RecognizeGeneralStructureResponseBodyDataSubImages> SubImages { get; set; }
            public class RecognizeGeneralStructureResponseBodyDataSubImages : TeaModel {
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public int? Angle { get; set; }

                [NameInMap("KvInfo")]
                [Validation(Required=false)]
                public RecognizeGeneralStructureResponseBodyDataSubImagesKvInfo KvInfo { get; set; }
                public class RecognizeGeneralStructureResponseBodyDataSubImagesKvInfo : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public object Data { get; set; }

                    [NameInMap("KvCount")]
                    [Validation(Required=false)]
                    public int? KvCount { get; set; }

                }

                [NameInMap("SubImageId")]
                [Validation(Required=false)]
                public int? SubImageId { get; set; }

            }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
