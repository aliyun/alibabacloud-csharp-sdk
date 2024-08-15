// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDbProxyInstanceSslRequest : TeaModel {
        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// The dedicated proxy endpoint of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbProxyConnectString")]
        [Validation(Required=false)]
        public string DbProxyConnectString { get; set; }

        /// <summary>
        /// The ID of the proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the ID of the proxy endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbProxyEndpointId")]
        [Validation(Required=false)]
        public string DbProxyEndpointId { get; set; }

        /// <summary>
        /// The SSL configuration setting that you want to apply on the instance. Valid values:
        /// 
        /// *   0: disables SSL encryption.
        /// *   1: enables SSL encryption or modifies the endpoint that requires SSL encryption.
        /// *   2: updates the validity period of the SSL certificate.
        /// 
        /// > This setting causes your instance to restart. Proceed with caution.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbProxySslEnabled")]
        [Validation(Required=false)]
        public string DbProxySslEnabled { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
