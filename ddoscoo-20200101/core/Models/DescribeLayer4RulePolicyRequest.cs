// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeLayer4RulePolicyRequest : TeaModel {
        /// <summary>
        /// The port forwarding rule that you want to query.
        /// 
        /// This parameter is a string that consists of JSON arrays. Each element in a JSON array indicates a port forwarding rule. You can query only one port forwarding rule at a time.
        /// 
        /// > You can call the [DescribeNetworkRules](https://help.aliyun.com/document_detail/157484.html) to query existing port forwarding rules.
        /// 
        /// Each port forwarding rule contains the following fields:
        /// 
        /// *   **InstanceId**: the ID of the instance. This field is required and must be of the string type.
        /// *   **Protocol**: the forwarding protocol. This field is required and must be of the string type. Valid values: **tcp** and **udp**.
        /// *   **FrontendPort**: the forwarding port. This field is required and must be of the integer type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
