// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListPreferredEcsTypesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of recommended ECS instances. Each SeriesInfo element contains the recommended ECS instance types for various nodes in the E-HPC cluster.
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public ListPreferredEcsTypesResponseBodySeries Series { get; set; }
        public class ListPreferredEcsTypesResponseBodySeries : TeaModel {
            [NameInMap("SeriesInfo")]
            [Validation(Required=false)]
            public List<ListPreferredEcsTypesResponseBodySeriesSeriesInfo> SeriesInfo { get; set; }
            public class ListPreferredEcsTypesResponseBodySeriesSeriesInfo : TeaModel {
                /// <summary>
                /// Recommended instance types for nodes in an E-HPC cluser.
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRoles Roles { get; set; }
                public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRoles : TeaModel {
                    /// <summary>
                    /// The list of recommended ECS instance types for compute nodes.
                    /// </summary>
                    [NameInMap("Compute")]
                    [Validation(Required=false)]
                    public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesCompute Compute { get; set; }
                    public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesCompute : TeaModel {
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypeId { get; set; }

                    }

                    /// <summary>
                    /// The list of recommended ECS instance types for logon nodes.
                    /// </summary>
                    [NameInMap("Login")]
                    [Validation(Required=false)]
                    public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesLogin Login { get; set; }
                    public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesLogin : TeaModel {
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypeId { get; set; }

                    }

                    /// <summary>
                    /// The list of recommended ECS instance types for management nodes.
                    /// </summary>
                    [NameInMap("Manager")]
                    [Validation(Required=false)]
                    public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesManager Manager { get; set; }
                    public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesManager : TeaModel {
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypeId { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the ECS instance series. Valid values:
                /// 
                /// *   HighCompute: compute-optimized instance families
                /// *   HighMem: memory-optimized instance families
                /// *   GPU: GPU-accelerated instance families
                /// *   All: all instance families
                /// </summary>
                [NameInMap("SeriesId")]
                [Validation(Required=false)]
                public string SeriesId { get; set; }

                /// <summary>
                /// The name of the instance series. Valid values:
                /// 
                /// *   SeriesHighCompute
                /// *   SeriesHighMem
                /// *   SeriesGPU
                /// *   SeriesAll
                /// </summary>
                [NameInMap("SeriesName")]
                [Validation(Required=false)]
                public string SeriesName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether preemptible instances are supported.
        /// </summary>
        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

    }

}
