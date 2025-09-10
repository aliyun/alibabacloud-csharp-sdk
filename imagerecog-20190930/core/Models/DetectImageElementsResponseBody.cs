// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class DetectImageElementsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectImageElementsResponseBodyData Data { get; set; }
        public class DetectImageElementsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectImageElementsResponseBodyDataElements> Elements { get; set; }
            public class DetectImageElementsResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>354</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.997097373008728</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>majorhuman</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>285</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>287</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7EE82437-AEC4-5AAF-819F-AB28C23EE0FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
