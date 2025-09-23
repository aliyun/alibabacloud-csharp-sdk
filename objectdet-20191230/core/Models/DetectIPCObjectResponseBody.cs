// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectIPCObjectResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectIPCObjectResponseBodyData Data { get; set; }
        public class DetectIPCObjectResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectIPCObjectResponseBodyDataElements> Elements { get; set; }
            public class DetectIPCObjectResponseBodyDataElements : TeaModel {
                [NameInMap("Box")]
                [Validation(Required=false)]
                public List<long?> Box { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.7138671875</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8566723958333333</para>
                /// </summary>
                [NameInMap("TargetRate")]
                [Validation(Required=false)]
                public float? TargetRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DOG</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1600</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7AE23740-A3E5-5607-8E10-895DCBD4C260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
