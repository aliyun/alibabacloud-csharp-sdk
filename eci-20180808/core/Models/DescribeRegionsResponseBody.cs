// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The list of recommended zones.</para>
            /// </summary>
            [NameInMap("RecommendZones")]
            [Validation(Required=false)]
            public List<string> RecommendZones { get; set; }

            /// <summary>
            /// <para>The endpoint for the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eci.aliyuncs.com</para>
            /// </summary>
            [NameInMap("RegionEndpoint")]
            [Validation(Required=false)]
            public string RegionEndpoint { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of unavailable zones.</para>
            /// </summary>
            [NameInMap("UnavailableZones")]
            [Validation(Required=false)]
            public List<string> UnavailableZones { get; set; }

            /// <summary>
            /// <para>The queried zones.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89945DD3-9072-47D0-A318-353284CFC7B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
