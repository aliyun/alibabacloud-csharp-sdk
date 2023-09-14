// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and sends the request. If the request passes the dry run, a `2xx HTTP` status code is returned and the operation is performed. This is the default value.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the ALB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the ALB instance. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The configuration read-only mode.
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public UpdateLoadBalancerAttributeRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class UpdateLoadBalancerAttributeRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// It must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
            /// 
            /// This parameter takes effect only when **ModificationProtectionStatus** is set to **ConsoleProtection**.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The status of the configuration read-only mode. Valid values:
            /// 
            /// *   **NonProtection**: disables the configuration read-only mode. In this case, you cannot specify **ModificationProtectionReason**. If you specify **ModificationProtectionReason**, the value of the parameter is cleared.
            /// *   **ConsoleProtection**: enables the configuration read-only mode. In this case, you can specify **ModificationProtectionReason**.
            /// 
            /// > If you set this parameter to **ConsoleProtection**, you cannot use the ALB console to modify instance configurations. However, you can call API operations to modify instance configurations.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
