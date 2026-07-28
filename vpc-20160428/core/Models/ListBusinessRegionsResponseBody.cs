// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListBusinessRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The list of regions where Express Connect circuits are available for purchase.</para>
        /// </summary>
        [NameInMap("GeographicSubRegions")]
        [Validation(Required=false)]
        public List<ListBusinessRegionsResponseBodyGeographicSubRegions> GeographicSubRegions { get; set; }
        public class ListBusinessRegionsResponseBodyGeographicSubRegions : TeaModel {
            /// <summary>
            /// <para>The name of the region where Express Connect circuits are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>华东1(杭州)</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID where Express Connect circuits are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>304FE68E-16D8-5B90-B2B3-FE5C5C08C24B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
