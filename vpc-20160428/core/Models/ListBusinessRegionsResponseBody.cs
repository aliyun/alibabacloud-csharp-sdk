// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListBusinessRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The list of regions available for Express Connect circuits.</para>
        /// </summary>
        [NameInMap("GeographicSubRegions")]
        [Validation(Required=false)]
        public List<ListBusinessRegionsResponseBodyGeographicSubRegions> GeographicSubRegions { get; set; }
        public class ListBusinessRegionsResponseBodyGeographicSubRegions : TeaModel {
            /// <summary>
            /// <para>The name of the region where circuits are available.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region where circuits are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>304FE68E-16D8-5B90-B2B3-FE5C5C08C24B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
