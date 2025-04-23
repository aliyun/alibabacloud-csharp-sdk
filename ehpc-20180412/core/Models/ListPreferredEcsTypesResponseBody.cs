// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListPreferredEcsTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of recommended ECS instances. Each SeriesInfo element contains the recommended ECS instance types for various nodes in the E-HPC cluster.</para>
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
                /// <para>Recommended instance types for nodes in an E-HPC cluser.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRoles Roles { get; set; }
                public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRoles : TeaModel {
                    /// <summary>
                    /// <para>The list of recommended ECS instance types for compute nodes.</para>
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
                    /// <para>The list of recommended ECS instance types for logon nodes.</para>
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
                    /// <para>The list of recommended ECS instance types for management nodes.</para>
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
                /// <para>The ID of the ECS instance series. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HighCompute: compute-optimized instance families</description></item>
                /// <item><description>HighMem: memory-optimized instance families</description></item>
                /// <item><description>GPU: GPU-accelerated instance families</description></item>
                /// <item><description>All: all instance families</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("SeriesId")]
                [Validation(Required=false)]
                public string SeriesId { get; set; }

                /// <summary>
                /// <para>The name of the instance series. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SeriesHighCompute</description></item>
                /// <item><description>SeriesHighMem</description></item>
                /// <item><description>SeriesGPU</description></item>
                /// <item><description>SeriesAll</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SeriesAll</para>
                /// </summary>
                [NameInMap("SeriesName")]
                [Validation(Required=false)]
                public string SeriesName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether preemptible instances are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

    }

}
