// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class InitiateAttendedTransferRequest : TeaModel {
        [NameInMap("CallPriority")]
        [Validation(Required=false)]
        public int? CallPriority { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("QueuingOverflowThreshold")]
        [Validation(Required=false)]
        public long? QueuingOverflowThreshold { get; set; }

        [NameInMap("QueuingTimeoutSeconds")]
        [Validation(Required=false)]
        public long? QueuingTimeoutSeconds { get; set; }

        [NameInMap("RoutingType")]
        [Validation(Required=false)]
        public string RoutingType { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        [NameInMap("StrategyParams")]
        [Validation(Required=false)]
        public string StrategyParams { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Transferee")]
        [Validation(Required=false)]
        public string Transferee { get; set; }

        [NameInMap("TransfereeType")]
        [Validation(Required=false)]
        public string TransfereeType { get; set; }

        [NameInMap("Transferor")]
        [Validation(Required=false)]
        public string Transferor { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
