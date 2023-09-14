// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// The information about the areas.
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAccelerateAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// The area ID.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The area name.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The regions in the acceleration area.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// The region name.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
