// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyNetworkRuleAttributeRequest : TeaModel {
        /// <summary>
        /// The session persistence settings of the port forwarding rule. This parameter is a JSON string. The string contains the following fields:
        /// 
        /// *   **PersistenceTimeout**: The timeout period of session persistence. This field is required and must be of the integer type. Valid values: **30** to **3600**. Unit: seconds. Default value: **0**. A value of 0 indicates that session persistence is disabled.
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
