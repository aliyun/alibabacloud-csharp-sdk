// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class GetImageTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A JSON object that contains the returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetImageTranslateTaskResponseBodyData Data { get; set; }
        public class GetImageTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213e391517328463424251152ec9fb</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <para>An object containing the translation result.</para>
            /// </summary>
            [NameInMap("translation")]
            [Validation(Required=false)]
            public GetImageTranslateTaskResponseBodyDataTranslation Translation { get; set; }
            public class GetImageTranslateTaskResponseBodyDataTranslation : TeaModel {
                /// <summary>
                /// <para>The rotation angle of the image in degrees.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                /// <summary>
                /// <para>An array of detected bounding boxes.</para>
                /// </summary>
                [NameInMap("boundingBoxes")]
                [Validation(Required=false)]
                public List<GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxes> BoundingBoxes { get; set; }
                public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxes : TeaModel {
                    /// <summary>
                    /// <para>The confidence score for the recognized text. The value ranges from 0 (lowest confidence) to 1 (highest confidence).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.99</para>
                    /// </summary>
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The text direction. Valid values: <c>0</c> (horizontal) and <c>1</c> (vertical).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public long? Direction { get; set; }

                    /// <summary>
                    /// <para>The coordinates of the lower-left corner of the bounding box.</para>
                    /// </summary>
                    [NameInMap("downLeft")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownLeft DownLeft { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownLeft : TeaModel {
                        /// <summary>
                        /// <para>The x-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>145</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The coordinates of the lower-right corner of the bounding box.</para>
                    /// </summary>
                    [NameInMap("downRight")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownRight DownRight { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownRight : TeaModel {
                        /// <summary>
                        /// <para>The x-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>327</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>148</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The cell ID of the bounding box. If the bounding box is not part of a table, the value is <c>-1</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("tableCellId")]
                    [Validation(Required=false)]
                    public long? TableCellId { get; set; }

                    /// <summary>
                    /// <para>The ID of the table that contains the bounding box. If the bounding box is not part of a table, the value is <c>-1</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("tableId")]
                    [Validation(Required=false)]
                    public long? TableId { get; set; }

                    /// <summary>
                    /// <para>The source-language text within the bounding box.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>修护头皮</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>An object containing the translated text, keyed by the target language code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;en&quot;: &quot;Restore Scalp Health&quot; }</para>
                    /// </summary>
                    [NameInMap("translation")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Translation { get; set; }

                    /// <summary>
                    /// <para>The coordinates of the upper-left corner of the bounding box.</para>
                    /// </summary>
                    [NameInMap("upLeft")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpLeft UpLeft { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpLeft : TeaModel {
                        /// <summary>
                        /// <para>The x-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>66</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The coordinates of the upper-right corner of the bounding box.</para>
                    /// </summary>
                    [NameInMap("upRight")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpRight UpRight { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpRight : TeaModel {
                        /// <summary>
                        /// <para>The x-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>328</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>69</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of detected bounding boxes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("boxesCount")]
                [Validation(Required=false)]
                public long? BoxesCount { get; set; }

                /// <summary>
                /// <para>The height of the image after rotation, in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <para>The height of the original image, in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("orgHeight")]
                [Validation(Required=false)]
                public long? OrgHeight { get; set; }

                /// <summary>
                /// <para>The width of the original image, in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("orgWidth")]
                [Validation(Required=false)]
                public long? OrgWidth { get; set; }

                /// <summary>
                /// <para>Information about tables detected in the image.</para>
                /// </summary>
                [NameInMap("tableInfos")]
                [Validation(Required=false)]
                public List<GetImageTranslateTaskResponseBodyDataTranslationTableInfos> TableInfos { get; set; }
                public class GetImageTranslateTaskResponseBodyDataTranslationTableInfos : TeaModel {
                    /// <summary>
                    /// <para>Information about the cells within the table.</para>
                    /// </summary>
                    [NameInMap("cellInfos")]
                    [Validation(Required=false)]
                    public List<GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfos> CellInfos { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfos : TeaModel {
                        /// <summary>
                        /// <para>An array of coordinates defining the cell\&quot;s bounding box.</para>
                        /// </summary>
                        [NameInMap("pos")]
                        [Validation(Required=false)]
                        public List<GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfosPos> Pos { get; set; }
                        public class GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfosPos : TeaModel {
                            /// <summary>
                            /// <para>The x-coordinate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>33</para>
                            /// </summary>
                            [NameInMap("x")]
                            [Validation(Required=false)]
                            public long? X { get; set; }

                            /// <summary>
                            /// <para>The y-coordinate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("y")]
                            [Validation(Required=false)]
                            public long? Y { get; set; }

                        }

                        /// <summary>
                        /// <para>The cell ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("tableCellId")]
                        [Validation(Required=false)]
                        public long? TableCellId { get; set; }

                        /// <summary>
                        /// <para>The text content of the cell.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>活动价</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The ending column index of the cell. The index starts from 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("xec")]
                        [Validation(Required=false)]
                        public long? Xec { get; set; }

                        /// <summary>
                        /// <para>The starting column index of the cell. The index starts from 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("xsc")]
                        [Validation(Required=false)]
                        public long? Xsc { get; set; }

                        /// <summary>
                        /// <para>The ending row index of the cell. The index starts from 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("yec")]
                        [Validation(Required=false)]
                        public long? Yec { get; set; }

                        /// <summary>
                        /// <para>The starting row index of the cell. The index starts from 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("ysc")]
                        [Validation(Required=false)]
                        public long? Ysc { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("tableId")]
                    [Validation(Required=false)]
                    public long? TableId { get; set; }

                    /// <summary>
                    /// <para>The number of columns in the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("xCellSize")]
                    [Validation(Required=false)]
                    public long? XCellSize { get; set; }

                    /// <summary>
                    /// <para>The number of rows in the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("yCellSize")]
                    [Validation(Required=false)]
                    public long? YCellSize { get; set; }

                }

                /// <summary>
                /// <para>The width of the image after rotation, in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, used to trace the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>377A48D7-7CFA-53F9-8CA2-14FE3F2774B6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is synchronous.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
