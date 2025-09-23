// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleIllegalParkingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVehicleIllegalParkingResponseBodyData Data { get; set; }
        public class DetectVehicleIllegalParkingResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingResponseBodyDataElements> Elements { get; set; }
            public class DetectVehicleIllegalParkingResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<DetectVehicleIllegalParkingResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class DetectVehicleIllegalParkingResponseBodyDataElementsBoxes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>268</para>
                    /// </summary>
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public long? Bottom { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>413</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public long? Left { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>499</para>
                    /// </summary>
                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public long? Right { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>138</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public long? Top { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.9599609375</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vehicle</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            [NameInMap("RegionIntersects")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingResponseBodyDataRegionIntersects> RegionIntersects { get; set; }
            public class DetectVehicleIllegalParkingResponseBodyDataRegionIntersects : TeaModel {
                [NameInMap("Ids")]
                [Validation(Required=false)]
                public List<long?> Ids { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DB882EDD-991A-5A0C-A19B-CC7C4BA65E35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
