// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetIntegratedServiceStatusResponseBody : TeaModel {
        [NameInMap("AggregatorDeliveryDataType")]
        [Validation(Required=false)]
        public string AggregatorDeliveryDataType { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        [NameInMap("IntegratedTypes")]
        [Validation(Required=false)]
        public string IntegratedTypes { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
