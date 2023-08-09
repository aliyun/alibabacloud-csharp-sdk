// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DisableActivationResponseBody : TeaModel {
        /// <summary>
        /// The time when the activation code was created.
        /// </summary>
        [NameInMap("Activation")]
        [Validation(Required=false)]
        public DisableActivationResponseBodyActivation Activation { get; set; }
        public class DisableActivationResponseBodyActivation : TeaModel {
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// The number of instances that were deregistered.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The maximum number of times that the activation code can be used to register managed instances.
            /// </summary>
            [NameInMap("DeregisteredCount")]
            [Validation(Required=false)]
            public int? DeregisteredCount { get; set; }

            /// <summary>
            /// The number of registered instances.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The IP addresses of the hosts that can use the activation code.
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// The description of the activation code.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// Indicates whether the activation code is disabled.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The validity period of the activation code. Unit: hours.
            /// </summary>
            [NameInMap("IpAddressRange")]
            [Validation(Required=false)]
            public string IpAddressRange { get; set; }

            /// <summary>
            /// The default prefix of the instance name.
            /// </summary>
            [NameInMap("RegisteredCount")]
            [Validation(Required=false)]
            public int? RegisteredCount { get; set; }

            /// <summary>
            /// The activation code ID.
            /// </summary>
            [NameInMap("TimeToLiveInHours")]
            [Validation(Required=false)]
            public long? TimeToLiveInHours { get; set; }

        }

        /// <summary>
        /// Details about the activation code and its usage information.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
