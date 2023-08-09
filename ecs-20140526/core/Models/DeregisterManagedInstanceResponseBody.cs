// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeregisterManagedInstanceResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DeregisterManagedInstanceResponseBodyInstance Instance { get; set; }
        public class DeregisterManagedInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// The ID of the managed instance.
            /// </summary>
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// The internal IP address of the managed instance.
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// The public IP address of the managed instance.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// The hostname of the managed instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the managed instance was registered.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The time when the Cloud Assistant task was last executed.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The ID of the activation code.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// Details of the managed instance.
            /// </summary>
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }

            /// <summary>
            /// The name of the managed instance.
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The operating system type of the managed instance.
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// The version number of the Cloud Assistant client.
            /// </summary>
            [NameInMap("RegistrationTime")]
            [Validation(Required=false)]
            public string RegistrationTime { get; set; }

        }

        /// <summary>
        /// The ID of the managed instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
