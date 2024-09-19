// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyNetworkRuleAttributeRequest : TeaModel {
        /// <summary>
        /// The detailed settings of the port forwarding rule. This parameter is a JSON string and contains the following fields. The detailed settings of a TCP port forwarding rule contain the following fields.
        /// 
        /// *   **PersistenceTimeout**: the timeout period of session persistence. This field is required and of the integer type. Valid values: **30** to **3600**. Unit: seconds. Default value: **0**, which indicates that session persistence is disabled.
        /// *   **Synproxy**: specifies whether to enable the false source feature in the DDoS mitigation policy. This field is required and of the string type. Valid values: off and on.
        /// *   **NodataConn**: specifies whether to enable the empty connection feature in the DDoS mitigation policy. This field is required and of the string type. Valid values: off and on.
        /// *   **Sla**: the settings of the speed limit for destination feature. This field is required and of the struct type. For more information, see the following description about Sla.
        /// *   **Slimit**: the settings of the rate limit for source feature. This field is required and of the struct type. For more information, see the following description about Slimit.
        /// *   **PayloadLen**: the settings of the packet length limit feature. This field is required and of the struct type. For more information, see the following description about PayloadLen.
        /// 
        /// Sla contains the following fields:
        /// 
        /// *   **Cps**: the destination rate limit on new connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 100 to 100000.
        /// *   **Maxconn**: the destination rate limit on concurrent connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 1000 to 1000000.
        /// *   **CpsEnable**: specifies whether to enable Cps. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Cps is disabled, and the value 1 indicates that Cps is enabled.
        /// *   **MaxconnEnable**: specifies whether to enable Maxconn. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Maxconn is disabled, and the value 1 indicates that Maxconn is enabled.
        /// 
        /// Slimit contains the following fields:
        /// 
        /// *   **Cps**: the source rate limit on new connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 1 to 50000.
        /// *   **Maxconn**: the source rate limit on concurrent connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 1 to 50000.
        /// *   **CpsEnable**: specifies whether to enable Cps. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Cps is disabled, and the value 1 indicates that Cps is enabled.
        /// *   **MaxconnEnable**: specifies whether to enable Maxconn. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Maxconn is disabled, and the value 1 indicates that Maxconn is enabled.
        /// *   **CpsMode**: specifies whether to enable the source rate limit on new connections. This field is required and of the integer type. Valid values: 1 and 2. The value 1 indicates the source rate limit is enabled. The value 2 indicates that the system determines whether to enable the source rate limit.
        /// 
        /// PayloadLen contains the following fields:
        /// 
        /// *   **Min**: the minimum packet length in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 0 to 2000.
        /// *   **Max**: the maximum packet length in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 0 to 6000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The forwarding protocol. Valid values:
        /// 
        /// *   **tcp**
        /// *   **udp**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// The forwarding port.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
