// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class DataSubImagesFigureInfoValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FigureCount")]
        [Validation(Required=false)]
        public int? FigureCount { get; set; }

        [NameInMap("FigureDetails")]
        [Validation(Required=false)]
        public List<DataSubImagesFigureInfoValueFigureDetails> FigureDetails { get; set; }
        public class DataSubImagesFigureInfoValueFigureDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>face</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public object Data { get; set; }

            [NameInMap("FigurePoints")]
            [Validation(Required=false)]
            public List<DataSubImagesFigureInfoValueFigureDetailsFigurePoints> FigurePoints { get; set; }
            public class DataSubImagesFigureInfoValueFigureDetailsFigurePoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

            [NameInMap("FigureRect")]
            [Validation(Required=false)]
            public DataSubImagesFigureInfoValueFigureDetailsFigureRect FigureRect { get; set; }
            public class DataSubImagesFigureInfoValueFigureDetailsFigureRect : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CenterX")]
                [Validation(Required=false)]
                public int? CenterX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("CenterY")]
                [Validation(Required=false)]
                public int? CenterY { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FigureAngle")]
            [Validation(Required=false)]
            public int? FigureAngle { get; set; }

        }

    }

}
