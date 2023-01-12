// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasResponseBody : TeaModel {
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListCommonAreasResponseBodyAreas> Areas { get; set; }
        public class ListCommonAreasResponseBodyAreas : TeaModel {
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListCommonAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListCommonAreasResponseBodyAreasRegionList : TeaModel {
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
