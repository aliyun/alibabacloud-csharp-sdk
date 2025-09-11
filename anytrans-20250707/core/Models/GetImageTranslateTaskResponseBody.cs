// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class GetImageTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetImageTranslateTaskResponseBodyData Data { get; set; }
        public class GetImageTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>213e391517328463424251152ec9fb</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("translation")]
            [Validation(Required=false)]
            public GetImageTranslateTaskResponseBodyDataTranslation Translation { get; set; }
            public class GetImageTranslateTaskResponseBodyDataTranslation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                [NameInMap("boundingBoxes")]
                [Validation(Required=false)]
                public List<GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxes> BoundingBoxes { get; set; }
                public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public long? Direction { get; set; }

                    [NameInMap("downLeft")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownLeft DownLeft { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownLeft : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>694</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    [NameInMap("downRight")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownRight DownRight { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesDownRight : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>97</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>694</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("tableCellId")]
                    [Validation(Required=false)]
                    public long? TableCellId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tbl-1dd15f7e-e373-4da9-858e-8785db1a2954</para>
                    /// </summary>
                    [NameInMap("tableId")]
                    [Validation(Required=false)]
                    public long? TableId { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{
                    ///           &quot;en&quot;: &quot;Promotional price:&quot;
                    ///         }</para>
                    /// </summary>
                    [NameInMap("translation")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Translation { get; set; }

                    [NameInMap("upLeft")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpLeft UpLeft { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpLeft : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>669</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    [NameInMap("upRight")]
                    [Validation(Required=false)]
                    public GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpRight UpRight { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationBoundingBoxesUpRight : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("boxesCount")]
                [Validation(Required=false)]
                public long? BoxesCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("orgHeight")]
                [Validation(Required=false)]
                public long? OrgHeight { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("orgWidth")]
                [Validation(Required=false)]
                public long? OrgWidth { get; set; }

                [NameInMap("tableInfos")]
                [Validation(Required=false)]
                public List<GetImageTranslateTaskResponseBodyDataTranslationTableInfos> TableInfos { get; set; }
                public class GetImageTranslateTaskResponseBodyDataTranslationTableInfos : TeaModel {
                    [NameInMap("cellInfos")]
                    [Validation(Required=false)]
                    public List<GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfos> CellInfos { get; set; }
                    public class GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfos : TeaModel {
                        [NameInMap("pos")]
                        [Validation(Required=false)]
                        public List<GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfosPos> Pos { get; set; }
                        public class GetImageTranslateTaskResponseBodyDataTranslationTableInfosCellInfosPos : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>33</para>
                            /// </summary>
                            [NameInMap("x")]
                            [Validation(Required=false)]
                            public long? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("y")]
                            [Validation(Required=false)]
                            public long? Y { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("tableCellId")]
                        [Validation(Required=false)]
                        public long? TableCellId { get; set; }

                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("xec")]
                        [Validation(Required=false)]
                        public long? Xec { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("xsc")]
                        [Validation(Required=false)]
                        public long? Xsc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("yec")]
                        [Validation(Required=false)]
                        public long? Yec { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("ysc")]
                        [Validation(Required=false)]
                        public long? Ysc { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tbl-f16944be-5955-466c-aa6c-940e4ed99a09</para>
                    /// </summary>
                    [NameInMap("tableId")]
                    [Validation(Required=false)]
                    public long? TableId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("xCellSize")]
                    [Validation(Required=false)]
                    public long? XCellSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("yCellSize")]
                    [Validation(Required=false)]
                    public long? YCellSize { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>377A48D7-7CFA-53F9-8CA2-14FE3F2774B6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
