// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasResponseBody : TeaModel {
        /// <summary>
        /// The information about the areas.
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListCommonAreasResponseBodyAreas> Areas { get; set; }
        public class ListCommonAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// The ID of the area.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The name of the area.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The information about the regions.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListCommonAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListCommonAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the region
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
