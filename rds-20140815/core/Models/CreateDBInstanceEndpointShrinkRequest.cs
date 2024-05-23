// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceEndpointShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The prefix of the internal endpoint.
        /// 
        /// When you create any type of endpoint, an internal endpoint is automatically created for the endpoint. This parameter specifies the prefix of the internal endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The user-defined description of the endpoint.
        /// </summary>
        [NameInMap("DBInstanceEndpointDescription")]
        [Validation(Required=false)]
        public string DBInstanceEndpointDescription { get; set; }

        /// <summary>
        /// The endpoint type. Valid values:
        /// 
        /// *   Primary: read/write endpoint of the instance
        /// *   Readonly: read-only endpoint of the instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceEndpointType")]
        [Validation(Required=false)]
        public string DBInstanceEndpointType { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The information about the endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeItems")]
        [Validation(Required=false)]
        public string NodeItemsShrink { get; set; }

        /// <summary>
        /// The port number of the internal endpoint. You can specify the port number for the internal endpoint.
        /// 
        /// Valid values: 3000 to 5999.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The IP address of the internal endpoint.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The resource group ID. You can call the DescribeDBInstanceAttribute operation to obtain the ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The vSwitch ID of the internal endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The VPC ID of the internal endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
