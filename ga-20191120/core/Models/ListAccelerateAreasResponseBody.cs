// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// The acceleration areas.
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAccelerateAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// The ID of the acceleration area.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The name of the acceleration area.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The list of regions.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
