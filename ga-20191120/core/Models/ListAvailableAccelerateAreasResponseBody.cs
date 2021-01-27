// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableAccelerateAreasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAvailableAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAvailableAccelerateAreasResponseBodyAreas : TeaModel {
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAvailableAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAvailableAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

    }

}
