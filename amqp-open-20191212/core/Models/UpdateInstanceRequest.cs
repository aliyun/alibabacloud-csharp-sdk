// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public int? MaxConnections { get; set; }

        [NameInMap("MaxEipTps")]
        [Validation(Required=false)]
        public long? MaxEipTps { get; set; }

        [NameInMap("MaxPrivateTps")]
        [Validation(Required=false)]
        public long? MaxPrivateTps { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("QueueCapacity")]
        [Validation(Required=false)]
        public int? QueueCapacity { get; set; }

        [NameInMap("ServerlessChargeType")]
        [Validation(Required=false)]
        public string ServerlessChargeType { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        [NameInMap("SupportEip")]
        [Validation(Required=false)]
        public bool? SupportEip { get; set; }

        [NameInMap("SupportTracing")]
        [Validation(Required=false)]
        public bool? SupportTracing { get; set; }

        [NameInMap("TracingStorageTime")]
        [Validation(Required=false)]
        public int? TracingStorageTime { get; set; }

    }

}
