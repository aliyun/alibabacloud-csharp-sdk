// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleIllegalParkingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectVehicleIllegalParking/DetectVehicleIllegalParking2.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectVehicleIllegalParking/DetectVehicleIllegalParking2.jpg</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public List<DetectVehicleIllegalParkingRequestRoadRegions> RoadRegions { get; set; }
        public class DetectVehicleIllegalParkingRequestRoadRegions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RoadRegion")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingRequestRoadRegionsRoadRegion> RoadRegion { get; set; }
            public class DetectVehicleIllegalParkingRequestRoadRegionsRoadRegion : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Point")]
                [Validation(Required=false)]
                public DetectVehicleIllegalParkingRequestRoadRegionsRoadRegionPoint Point { get; set; }
                public class DetectVehicleIllegalParkingRequestRoadRegionsRoadRegionPoint : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

            }

        }

    }

}
