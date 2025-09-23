// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectKitchenAnimalsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectKitchenAnimalsResponseBodyData Data { get; set; }
        public class DetectKitchenAnimalsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectKitchenAnimalsResponseBodyDataElements> Elements { get; set; }
            public class DetectKitchenAnimalsResponseBodyDataElements : TeaModel {
                [NameInMap("Rectangles")]
                [Validation(Required=false)]
                public DetectKitchenAnimalsResponseBodyDataElementsRectangles Rectangles { get; set; }
                public class DetectKitchenAnimalsResponseBodyDataElementsRectangles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public long? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>292</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public long? Left { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1048</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public long? Top { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public long? Width { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.75105053</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mouse</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C306F16F-30E1-54F4-93DF-A52CCF6664D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
