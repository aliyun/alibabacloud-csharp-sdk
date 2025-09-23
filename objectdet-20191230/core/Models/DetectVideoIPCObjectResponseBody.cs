// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVideoIPCObjectResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVideoIPCObjectResponseBodyData Data { get; set; }
        public class DetectVideoIPCObjectResponseBodyData : TeaModel {
            [NameInMap("Frames")]
            [Validation(Required=false)]
            public List<DetectVideoIPCObjectResponseBodyDataFrames> Frames { get; set; }
            public class DetectVideoIPCObjectResponseBodyDataFrames : TeaModel {
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<DetectVideoIPCObjectResponseBodyDataFramesElements> Elements { get; set; }
                public class DetectVideoIPCObjectResponseBodyDataFramesElements : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>156</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public long? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.7812</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PERSON</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public long? Width { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>289</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>271</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6124533574</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://viapi-test/viapi-3.0domepic/objectdet/DetectVideoIPCObject/DetectVideoIPCObject4.mp4</para>
            /// </summary>
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public string InputFile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35B11E1B-800C-4598-B5AA-577E3BDBD917</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
