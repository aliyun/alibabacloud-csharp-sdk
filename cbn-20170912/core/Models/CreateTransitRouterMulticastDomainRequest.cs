// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterMulticastDomainRequest : TeaModel {
        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The token can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the request. Valid values:
        /// 
        /// *   **true**: prechecks the request but does not create the multicast domain. The system checks the required parameters, the request format, and the service limits. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. After the request passes the precheck, the multicast domain is created.
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

        /// <summary>
        /// The ID of the region where the transit router is deployed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The information about the tags.
        /// 
        /// You can specify at most 20 tags in each call.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterMulticastDomainRequestTag> Tag { get; set; }
        public class CreateTransitRouterMulticastDomainRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// The tag key cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// 
            /// You can specify at most 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// The tag value can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// 
            /// Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the transit router.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// The description of the multicast domain.
        /// 
        /// The description must be 0 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainDescription")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainDescription { get; set; }

        /// <summary>
        /// The name of the multicast domain.
        /// 
        /// The name must be 0 to 128 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainName")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainName { get; set; }

    }

}
