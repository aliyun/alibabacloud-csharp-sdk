// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        [NameInMap("OrderInfo")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyOrderInfo OrderInfo { get; set; }
        public class CreateInstanceResponseBodyOrderInfo : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("StorageInstanceId")]
            [Validation(Required=false)]
            public string StorageInstanceId { get; set; }

            [NameInMap("StorageOrderId")]
            [Validation(Required=false)]
            public long? StorageOrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
