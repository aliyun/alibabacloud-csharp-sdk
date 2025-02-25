// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancerRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of region information</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListLoadBalancerRegionsResponseBodyRegions> Regions { get; set; }
        public class ListLoadBalancerRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>Primary region Chinese full name</para>
            /// 
            /// <b>Example:</b>
            /// <para>东南亚</para>
            /// </summary>
            [NameInMap("RegionCnName")]
            [Validation(Required=false)]
            public string RegionCnName { get; set; }

            /// <summary>
            /// <para>Primary region code</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEAS</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <para>Primary region English full name</para>
            /// 
            /// <b>Example:</b>
            /// <para>South East Asia</para>
            /// </summary>
            [NameInMap("RegionEnName")]
            [Validation(Required=false)]
            public string RegionEnName { get; set; }

            /// <summary>
            /// <para>List of secondary region information</para>
            /// </summary>
            [NameInMap("SubRegions")]
            [Validation(Required=false)]
            public List<ListLoadBalancerRegionsResponseBodyRegionsSubRegions> SubRegions { get; set; }
            public class ListLoadBalancerRegionsResponseBodyRegionsSubRegions : TeaModel {
                /// <summary>
                /// <para>Secondary region Chinese full name</para>
                /// 
                /// <b>Example:</b>
                /// <para>印度尼西亚</para>
                /// </summary>
                [NameInMap("SubRegionCnName")]
                [Validation(Required=false)]
                public string SubRegionCnName { get; set; }

                /// <summary>
                /// <para>Secondary region code</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("SubRegionCode")]
                [Validation(Required=false)]
                public string SubRegionCode { get; set; }

                /// <summary>
                /// <para>Secondary region English full name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Indonesia</para>
                /// </summary>
                [NameInMap("SubRegionEnName")]
                [Validation(Required=false)]
                public string SubRegionEnName { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>81A5E222-24BF-17EF-9E80-A68D9B8F363D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
