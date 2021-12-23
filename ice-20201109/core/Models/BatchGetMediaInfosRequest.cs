// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetMediaInfosRequest : TeaModel {
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
