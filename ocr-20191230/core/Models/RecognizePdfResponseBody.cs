// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizePdfResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePdfResponseBodyData Data { get; set; }
        public class RecognizePdfResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public long? Angle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>788</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>610</para>
            /// </summary>
            [NameInMap("OrgHeight")]
            [Validation(Required=false)]
            public long? OrgHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>394</para>
            /// </summary>
            [NameInMap("OrgWidth")]
            [Validation(Required=false)]
            public long? OrgWidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1220</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

            [NameInMap("WordsInfo")]
            [Validation(Required=false)]
            public List<RecognizePdfResponseBodyDataWordsInfo> WordsInfo { get; set; }
            public class RecognizePdfResponseBodyDataWordsInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("Positions")]
                [Validation(Required=false)]
                public List<RecognizePdfResponseBodyDataWordsInfoPositions> Positions { get; set; }
                public class RecognizePdfResponseBodyDataWordsInfoPositions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>863</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>43</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>205</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>863</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public long? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>46</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public long? Y { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CD9A9659-ABEE-4A7D-837F-9FDF40879A97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
