// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleICongestionAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectVehicleICongestion/DetectVehicleICongestion1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectVehicleICongestion/DetectVehicleICongestion1.jpg</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("PreRegionIntersectFeatures")]
        [Validation(Required=false)]
        public List<DetectVehicleICongestionAdvanceRequestPreRegionIntersectFeatures> PreRegionIntersectFeatures { get; set; }
        public class DetectVehicleICongestionAdvanceRequestPreRegionIntersectFeatures : TeaModel {
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public List<DetectVehicleICongestionAdvanceRequestRoadRegions> RoadRegions { get; set; }
        public class DetectVehicleICongestionAdvanceRequestRoadRegions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RoadRegion")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegion> RoadRegion { get; set; }
            public class DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegion : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Point")]
                [Validation(Required=false)]
                public DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegionPoint Point { get; set; }
                public class DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegionPoint : TeaModel {
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
