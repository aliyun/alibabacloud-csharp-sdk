// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRegistryRegionResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListImageRegistryRegionResponseBodyRegions> Regions { get; set; }
        public class ListImageRegistryRegionResponseBodyRegions : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
