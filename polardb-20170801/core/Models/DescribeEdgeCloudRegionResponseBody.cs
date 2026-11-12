// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeEdgeCloudRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available edge cloud regions. When a whitelist is configured, only the regions available to the current account are returned.</para>
        /// </summary>
        [NameInMap("EdgeCloudRegions")]
        [Validation(Required=false)]
        public List<DescribeEdgeCloudRegionResponseBodyEdgeCloudRegions> EdgeCloudRegions { get; set; }
        public class DescribeEdgeCloudRegionResponseBodyEdgeCloudRegions : TeaModel {
            /// <summary>
            /// <para>The ID of the central control region corresponding to the edge cloud region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("CentralControlRegionId")]
            [Validation(Required=false)]
            public string CentralControlRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the edge cloud region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-singapore</para>
            /// </summary>
            [NameInMap("EdgeCloudRegionId")]
            [Validation(Required=false)]
            public string EdgeCloudRegionId { get; set; }

            /// <summary>
            /// <para>The name of the edge cloud region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edgeCloudRegionName</para>
            /// </summary>
            [NameInMap("EdgeCloudRegionName")]
            [Validation(Required=false)]
            public string EdgeCloudRegionName { get; set; }

            /// <summary>
            /// <para>The list of standby edge cloud regions.</para>
            /// </summary>
            [NameInMap("StandbyEdgeCloudRegionList")]
            [Validation(Required=false)]
            public List<DescribeEdgeCloudRegionResponseBodyEdgeCloudRegionsStandbyEdgeCloudRegionList> StandbyEdgeCloudRegionList { get; set; }
            public class DescribeEdgeCloudRegionResponseBodyEdgeCloudRegionsStandbyEdgeCloudRegionList : TeaModel {
                /// <summary>
                /// <para>The ID of the standby edge cloud region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standbyEdgeCloudRegionId</para>
                /// </summary>
                [NameInMap("StandbyEdgeCloudRegionId")]
                [Validation(Required=false)]
                public string StandbyEdgeCloudRegionId { get; set; }

                /// <summary>
                /// <para>The name of the standby edge cloud region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standbyEdgeCloudRegionName</para>
                /// </summary>
                [NameInMap("StandbyEdgeCloudRegionName")]
                [Validation(Required=false)]
                public string StandbyEdgeCloudRegionName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
