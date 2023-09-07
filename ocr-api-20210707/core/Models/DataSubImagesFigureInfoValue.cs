/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class DataSubImagesFigureInfoValue : TeaModel {
        [NameInMap("FigureCount")]
        [Validation(Required=false)]
        public int? FigureCount { get; set; }

        [NameInMap("FigureDetails")]
        [Validation(Required=false)]
        public List<DataSubImagesFigureInfoValueFigureDetails> FigureDetails { get; set; }
        public class DataSubImagesFigureInfoValueFigureDetails : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public object Data { get; set; }

            [NameInMap("FigurePoints")]
            [Validation(Required=false)]
            public List<DataSubImagesFigureInfoValueFigureDetailsFigurePoints> FigurePoints { get; set; }
            public class DataSubImagesFigureInfoValueFigureDetailsFigurePoints : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

            [NameInMap("FigureRect")]
            [Validation(Required=false)]
            public DataSubImagesFigureInfoValueFigureDetailsFigureRect FigureRect { get; set; }
            public class DataSubImagesFigureInfoValueFigureDetailsFigureRect : TeaModel {
                [NameInMap("CenterX")]
                [Validation(Required=false)]
                public int? CenterX { get; set; }

                [NameInMap("CenterY")]
                [Validation(Required=false)]
                public int? CenterY { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

            }

            [NameInMap("FigureAngle")]
            [Validation(Required=false)]
            public int? FigureAngle { get; set; }

        }

    }

}
