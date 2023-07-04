// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVirtualPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The region ID of the hosted connection.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to obtain the region ID.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request without performing the operation. The hosted connection is not created. The system checks the required parameters, request syntax, and instance status. If the request fails the check, an error message is returned. If the request passes the check, `DRYRUN.SUCCESS` is returned.
        /// *   **false**: sends the request. If the request passes the check, the hosted connection is created. This is the default value.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The bandwidth value of the hosted connection.
        /// 
        /// Valid values: **50M**, **100M**, **200M**, **300M**, **400M**, **500M**, **1G**, **2G**, **5G**, **8G**, and **10G**.
        /// 
        /// >  By default, the values of **2G**, **5G**, **8G**, and **10G** are unavailable. If you want to specify these values, contact your customer manager.
        /// 
        /// **M** indicates Mbit/s, and **G** indicates Gbit/s.
        /// </summary>
        [NameInMap("OrderMode")]
        [Validation(Required=false)]
        public string OrderMode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically sets **ClientToken** to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// The ID of the hosted connection.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit over which the hosted connection is created.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVirtualPhysicalConnectionRequestTag> Tag { get; set; }
        public class CreateVirtualPhysicalConnectionRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description of the hosted connection.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the tenant.
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public long? VlanId { get; set; }

        /// <summary>
        /// The name of the hosted connection.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("VpconnAliUid")]
        [Validation(Required=false)]
        public long? VpconnAliUid { get; set; }

    }

}
