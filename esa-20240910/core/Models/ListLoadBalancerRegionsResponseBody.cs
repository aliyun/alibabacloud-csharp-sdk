// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancerRegionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListLoadBalancerRegionsResponseBodyRegions> Regions { get; set; }
        public class ListLoadBalancerRegionsResponseBodyRegions : TeaModel {
            [NameInMap("RegionCnName")]
            [Validation(Required=false)]
            public string RegionCnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SEAS</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>South East Asia</para>
            /// </summary>
            [NameInMap("RegionEnName")]
            [Validation(Required=false)]
            public string RegionEnName { get; set; }

            [NameInMap("SubRegions")]
            [Validation(Required=false)]
            public List<ListLoadBalancerRegionsResponseBodyRegionsSubRegions> SubRegions { get; set; }
            public class ListLoadBalancerRegionsResponseBodyRegionsSubRegions : TeaModel {
                [NameInMap("SubRegionCnName")]
                [Validation(Required=false)]
                public string SubRegionCnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("SubRegionCode")]
                [Validation(Required=false)]
                public string SubRegionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Indonesia</para>
                /// </summary>
                [NameInMap("SubRegionEnName")]
                [Validation(Required=false)]
                public string SubRegionEnName { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>81A5E222-24BF-17EF-9E80-A68D9B8F363D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
