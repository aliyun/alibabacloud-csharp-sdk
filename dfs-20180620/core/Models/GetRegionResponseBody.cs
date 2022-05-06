// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class GetRegionResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<GetRegionResponseBodyAvailableZones> AvailableZones { get; set; }
        public class GetRegionResponseBodyAvailableZones : TeaModel {
            [NameInMap("Options")]
            [Validation(Required=false)]
            public List<GetRegionResponseBodyAvailableZonesOptions> Options { get; set; }
            public class GetRegionResponseBodyAvailableZonesOptions : TeaModel {
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
