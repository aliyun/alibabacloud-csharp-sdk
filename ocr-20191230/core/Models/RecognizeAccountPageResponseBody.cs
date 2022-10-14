// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeAccountPageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeAccountPageResponseBodyData Data { get; set; }
        public class RecognizeAccountPageResponseBodyData : TeaModel {
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public float? Angle { get; set; }

            [NameInMap("BirthDate")]
            [Validation(Required=false)]
            public string BirthDate { get; set; }

            [NameInMap("BirthPlace")]
            [Validation(Required=false)]
            public string BirthPlace { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("IDNumber")]
            [Validation(Required=false)]
            public string IDNumber { get; set; }

            [NameInMap("InvalidStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataInvalidStampAreas> InvalidStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataInvalidStampAreas : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            [NameInMap("NativePlace")]
            [Validation(Required=false)]
            public string NativePlace { get; set; }

            [NameInMap("OtherStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataOtherStampAreas> OtherStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataOtherStampAreas : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("RegisterStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataRegisterStampAreas> RegisterStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataRegisterStampAreas : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            [NameInMap("TitleArea")]
            [Validation(Required=false)]
            public RecognizeAccountPageResponseBodyDataTitleArea TitleArea { get; set; }
            public class RecognizeAccountPageResponseBodyDataTitleArea : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("UndertakeStampAreas")]
            [Validation(Required=false)]
            public List<RecognizeAccountPageResponseBodyDataUndertakeStampAreas> UndertakeStampAreas { get; set; }
            public class RecognizeAccountPageResponseBodyDataUndertakeStampAreas : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
