// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GenerateAggregateResourceInventoryRequest : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIds { get; set; }

        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

    }

}
