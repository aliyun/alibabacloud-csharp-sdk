// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// The information about acceleration areas.
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAvailableAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAvailableAccelerateAreasResponseBodyAreas : TeaModel {
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
            /// The information about acceleration regions.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAvailableAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAvailableAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// The name of the acceleration region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the acceleration region.
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
