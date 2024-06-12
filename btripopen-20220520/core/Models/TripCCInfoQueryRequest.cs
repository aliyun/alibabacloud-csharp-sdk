// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripCCInfoQueryRequest : TeaModel {
        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("third_business_id")]
        [Validation(Required=false)]
        public string ThirdBusinessId { get; set; }

    }

}
