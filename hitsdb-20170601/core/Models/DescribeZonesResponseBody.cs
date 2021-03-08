// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20170601.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZoneList ZoneList { get; set; }
        public class DescribeZonesResponseBodyZoneList : TeaModel {
            [NameInMap("ZoneModel")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZoneListZoneModel> ZoneModel { get; set; }
            public class DescribeZonesResponseBodyZoneListZoneModel : TeaModel {
                public string LocalName { get; set; }
                public string ZoneId { get; set; }
            }
        };

    }

}
