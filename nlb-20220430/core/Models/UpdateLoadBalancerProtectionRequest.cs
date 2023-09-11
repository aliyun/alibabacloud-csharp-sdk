// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateLoadBalancerProtectionRequest : TeaModel {
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
        /// Specifies whether to enable deletion protection. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// The reason why deletion protection is enabled. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The reason must start with a letter.
        /// 
        /// > This parameter takes effect only when **DeletionProtectionEnabled** is set to **true**.
        /// </summary>
        [NameInMap("DeletionProtectionReason")]
        [Validation(Required=false)]
        public string DeletionProtectionReason { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The NLB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The reason why the configuration read-only mode is enabled. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The reason must start with a letter.
        /// 
        /// > This parameter takes effect only if **Status** is set to **ConsoleProtection**.
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// Specifies whether to enable the configuration read-only mode. Valid values:
        /// 
        /// *   **NonProtection**: disables the configuration read-only mode. In this case, you cannot set the **ModificationProtectionReason** parameter. If you specify **ModificationProtectionReason**, the value is cleared.
        /// *   **ConsoleProtection**: enables the configuration read-only mode. In this case, you can specify **ModificationProtectionReason**.
        /// 
        /// > If you set this parameter to **ConsoleProtection**, you cannot use the NLB console to modify instance configurations. However, you can call API operations to modify instance configurations.
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](~~443657~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
