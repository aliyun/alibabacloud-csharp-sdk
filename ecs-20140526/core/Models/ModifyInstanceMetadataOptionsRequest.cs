// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceMetadataOptionsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the access channel for instance metadata. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// 
        /// Default value: enabled.
        /// 
        /// > For more information about instance metadata, see [Overview of ECS instance metadata](~~49122~~).
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// > This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Specifies whether to forcibly use the security hardening mode (IMDSv2) to access instance metadata. Valid values:
        /// 
        /// *   optional: does not forcibly use the security hardening mode (IMDSv2).
        /// *   required: forcibly uses the security hardening mode (IMDSv2). After you set this parameter to required, you cannot access instance metadata in normal mode.
        /// 
        /// Default value: optional.
        /// 
        /// > For more information about the modes of accessing instance metadata, see [Access mode of instance metadata](~~150575~~).
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// > This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("InstanceMetadataTags")]
        [Validation(Required=false)]
        public string InstanceMetadataTags { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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

    }

}
