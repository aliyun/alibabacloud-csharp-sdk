// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RemarkRequest : TeaModel {
        /// <summary>
        /// The port forwarding rule that you want to manage.
        /// 
        /// This parameter is a string that consists of JSON arrays. Each element in a JSON array indicates a port forwarding rule. You can perform this operation only on one port forwarding rule at a time.
        /// 
        /// > You can call the [DescribeNetworkRules](~~157484~~) to query existing port forwarding rules.
        /// 
        /// Each port forwarding rule contains the following fields:
        /// 
        /// *   **InstanceId**: the ID of the instance. This field is required and must be of the STRING type.
        /// *   **Protocol**: the forwarding protocol. This field is required and must be of the STRING type. Valid values: **tcp** and **udp**.
        /// *   **FrontendPort**: the forwarding port. This field is required and must be of the INTEGER type.
        /// *   **Remark**: the remarks of the port forwarding rule. This field is required and must be of the STRING type. The value can contain letters, digits, and some special characters, such as `, . + - * / _`. The value can be up to 200 characters in length.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
