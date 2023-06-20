// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageResultExtResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageResultExtResponseBodyData Data { get; set; }
        public class DescribeImageResultExtResponseBodyData : TeaModel {
            [NameInMap("CustomImage")]
            [Validation(Required=false)]
            public List<DescribeImageResultExtResponseBodyDataCustomImage> CustomImage { get; set; }
            public class DescribeImageResultExtResponseBodyDataCustomImage : TeaModel {
                /// <summary>
                /// 图片ID。
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// 图库ID。
                /// </summary>
                [NameInMap("LibId")]
                [Validation(Required=false)]
                public string LibId { get; set; }

                /// <summary>
                /// 图库名。
                /// </summary>
                [NameInMap("LibName")]
                [Validation(Required=false)]
                public string LibName { get; set; }

            }

            [NameInMap("PublicFigure")]
            [Validation(Required=false)]
            public List<DescribeImageResultExtResponseBodyDataPublicFigure> PublicFigure { get; set; }
            public class DescribeImageResultExtResponseBodyDataPublicFigure : TeaModel {
                /// <summary>
                /// 人物ID。
                /// </summary>
                [NameInMap("FigureId")]
                [Validation(Required=false)]
                public string FigureId { get; set; }

            }

            [NameInMap("TextInImage")]
            [Validation(Required=false)]
            public DescribeImageResultExtResponseBodyDataTextInImage TextInImage { get; set; }
            public class DescribeImageResultExtResponseBodyDataTextInImage : TeaModel {
                [NameInMap("OcrDatas")]
                [Validation(Required=false)]
                public List<string> OcrDatas { get; set; }

                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public List<string> RiskWords { get; set; }

            }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
