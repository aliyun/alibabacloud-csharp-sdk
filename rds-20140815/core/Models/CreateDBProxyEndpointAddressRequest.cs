// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBProxyEndpointAddressRequest : TeaModel {
        /// <summary>
        /// The prefix of the proxy endpoint. Enter a custom prefix.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The network type of the proxy endpoint. Valid values:
        /// 
        /// *   **Public**: Internet
        /// *   **VPC**: Virtual Private Cloud (VPC)
        /// *   **Classic**: classic network
        /// 
        /// Default value: **Classic**
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// The ID of the proxy endpoint. You can call the [DescribeDBProxyEndpoint](~~610507~~) operation to query the ID of the proxy endpoint.
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The port number that is associated with the proxy endpoint.
        /// 
        /// *   If the instance runs MySQL, the default value is **3306**.
        /// *   If the instance runs PostgreSQL, the default value is **5432**.
        /// </summary>
        [NameInMap("DBProxyNewConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyNewConnectStringPort { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~610399~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the VPC to which the proxy endpoint belongs. You can call the [DescribeDBInstanceAttribute](~~610394~~) operation to query the VPC ID of the instance.
        /// 
        /// >  This parameter must be specified when DBProxyConnectStringNetType is set to **VPC**.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch that is associated with the specified VPC. You can call the [DescribeDBInstanceAttribute](~~610394~~) operation to query the vSwitch ID of the instance.
        /// 
        /// >  This parameter must be specified when DBProxyConnectStringNetType is set to **VPC**.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
