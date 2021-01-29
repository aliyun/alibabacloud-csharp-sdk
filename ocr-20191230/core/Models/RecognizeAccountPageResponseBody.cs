// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeAccountPageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeAccountPageResponseBodyData Data { get; set; }
        public class RecognizeAccountPageResponseBodyData : TeaModel {
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }
            [NameInMap("TitleArea")]
            [Validation(Required=false)]
            public RecognizeAccountPageResponseBodyDataTitleArea TitleArea { get; set; }
            public class RecognizeAccountPageResponseBodyDataTitleArea : TeaModel {
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

            }
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public float? Angle { get; set; }
            [NameInMap("RegisterStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataRegisterStampAreas> RegisterStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataRegisterStampAreas : TeaModel {
                public int? Top { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Left { get; set; }
            }
            [NameInMap("Nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }
            [NameInMap("BirthPlace")]
            [Validation(Required=false)]
            public string BirthPlace { get; set; }
            [NameInMap("OtherStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataOtherStampAreas> OtherStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataOtherStampAreas : TeaModel {
                public int? Top { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Left { get; set; }
            }
            [NameInMap("UndertakeStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataUndertakeStampAreas> UndertakeStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataUndertakeStampAreas : TeaModel {
                public int? Top { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Left { get; set; }
            }
            [NameInMap("BirthDate")]
            [Validation(Required=false)]
            public string BirthDate { get; set; }
            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }
            [NameInMap("NativePlace")]
            [Validation(Required=false)]
            public string NativePlace { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("IDNumber")]
            [Validation(Required=false)]
            public string IDNumber { get; set; }
            [NameInMap("InvalidStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataInvalidStampAreas> InvalidStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataInvalidStampAreas : TeaModel {
                public int? Top { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Left { get; set; }
            }
        };

    }

}
