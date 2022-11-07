// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public ListZonesResponseBodyZones Zones { get; set; }
        public class ListZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<ListZonesResponseBodyZonesZone> Zone { get; set; }
            public class ListZonesResponseBodyZonesZone : TeaModel {
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
