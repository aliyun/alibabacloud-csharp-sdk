// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

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

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodCycle")]
        [Validation(Required=false)]
        public string PeriodCycle { get; set; }

        [NameInMap("QueueCapacity")]
        [Validation(Required=false)]
        public int? QueueCapacity { get; set; }

        /// <summary>
        /// autoRenew和renewStatus都是续费方式，当两个同时填写时，以renewStatus为准
        /// </summary>
        [NameInMap("RenewStatus")]
        [Validation(Required=false)]
        public string RenewStatus { get; set; }

        [NameInMap("RenewalDurationUnit")]
        [Validation(Required=false)]
        public string RenewalDurationUnit { get; set; }

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
