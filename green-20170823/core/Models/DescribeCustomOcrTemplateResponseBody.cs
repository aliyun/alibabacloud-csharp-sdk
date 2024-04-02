// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeCustomOcrTemplateResponseBody : TeaModel {
        [NameInMap("OcrTemplateList")]
        [Validation(Required=false)]
        public List<DescribeCustomOcrTemplateResponseBodyOcrTemplateList> OcrTemplateList { get; set; }
        public class DescribeCustomOcrTemplateResponseBodyOcrTemplateList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ImgUrl")]
            [Validation(Required=false)]
            public string ImgUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RecognizeArea")]
            [Validation(Required=false)]
            public List<DescribeCustomOcrTemplateResponseBodyOcrTemplateListRecognizeArea> RecognizeArea { get; set; }
            public class DescribeCustomOcrTemplateResponseBodyOcrTemplateListRecognizeArea : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

            [NameInMap("ReferArea")]
            [Validation(Required=false)]
            public List<DescribeCustomOcrTemplateResponseBodyOcrTemplateListReferArea> ReferArea { get; set; }
            public class DescribeCustomOcrTemplateResponseBodyOcrTemplateListReferArea : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
