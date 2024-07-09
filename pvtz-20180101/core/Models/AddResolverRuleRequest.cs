// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddResolverRuleRequest : TeaModel {
        /// <summary>
        /// The endpoint ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The destination IP address and port number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ForwardIp")]
        [Validation(Required=false)]
        public List<AddResolverRuleRequestForwardIp> ForwardIp { get; set; }
        public class AddResolverRuleRequestForwardIp : TeaModel {
            /// <summary>
            /// The destination IP address.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The port number.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The name of the forwarding rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the forwarding rule. Valid value:
        /// 
        /// *   OUTBOUND: forwards Domain Name System (DNS) requests to one or more external IP addresses.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The name of the forward zone.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
