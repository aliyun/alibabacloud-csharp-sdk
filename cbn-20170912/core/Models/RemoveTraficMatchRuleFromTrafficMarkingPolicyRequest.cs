// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class RemoveTraficMatchRuleFromTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. 
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The client token can contain only ASCII characters.  
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the request. Valid values:
        /// 
        /// - **true**: prechecks the request but does not delete the traffic classification rules. The system checks the required parameters, the request format, and the service limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// - **false** (default): sends the request and deletes the specified traffic classification rules after the request passes the precheck.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of the traffic classification rules.
        /// 
        /// You can specify at most 20 traffic classification rules.
        /// 
        /// You can call the ListTrafficMarkingPolicies operation to query the IDs of traffic classification rules in a specified traffic marking policy.
        /// </summary>
        [NameInMap("TrafficMarkRuleIds")]
        [Validation(Required=false)]
        public List<string> TrafficMarkRuleIds { get; set; }

        /// <summary>
        /// The ID of the traffic marking policy.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyId")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyId { get; set; }

    }

}
