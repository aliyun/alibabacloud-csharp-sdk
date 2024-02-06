// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySDGRequest : TeaModel {
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
