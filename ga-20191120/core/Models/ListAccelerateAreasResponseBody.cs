// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAccelerateAreasResponseBody : TeaModel {
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAccelerateAreasResponseBodyAreas : TeaModel {
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
