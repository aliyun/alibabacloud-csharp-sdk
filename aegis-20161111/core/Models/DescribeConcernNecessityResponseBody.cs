// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aegis20161111.Models
{
    public class DescribeConcernNecessityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConcernNecessity")]
        [Validation(Required=false)]
        public List<string> ConcernNecessity { get; set; }

    }

}
