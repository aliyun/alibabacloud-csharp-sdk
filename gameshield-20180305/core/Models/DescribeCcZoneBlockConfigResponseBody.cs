// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcZoneBlockConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("BlockConfig")]
        [Validation(Required=false)]
        public DescribeCcZoneBlockConfigResponseBodyBlockConfig BlockConfig { get; set; }
        public class DescribeCcZoneBlockConfigResponseBodyBlockConfig : TeaModel {
            [NameInMap("CcZones")]
            [Validation(Required=false)]
            public List<DescribeCcZoneBlockConfigResponseBodyBlockConfigCcZones> CcZones { get; set; }
            public class DescribeCcZoneBlockConfigResponseBodyBlockConfigCcZones : TeaModel {
                public List<string> Provinces { get; set; }
                public string Country { get; set; }
            }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }
        };

    }

}
