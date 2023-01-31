// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListGeographicSubRegionsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("GeographicSubRegions")]
        [Validation(Required=false)]
        public List<string> GeographicSubRegions { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
