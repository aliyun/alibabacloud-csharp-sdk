// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to enable hardware acceleration.
        /// </summary>
        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        /// <summary>
        /// Specifies whether to activate Log Service.
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// Specifies whether to activate Tracing Analysis.
        /// </summary>
        [NameInMap("EnableXtrace")]
        [Validation(Required=false)]
        public bool? EnableXtrace { get; set; }

        /// <summary>
        /// Specifies whether to use an advanced security group.
        /// </summary>
        [NameInMap("EnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? EnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// The specifications of the Internet-facing SLB instance. Valid values:
        /// 
        /// *   slb.s1.small
        /// *   slb.s2.small
        /// *   slb.s2.medium
        /// *   slb.s3.small
        /// *   slb.s3.medium
        /// *   slb.s3.large
        /// </summary>
        [NameInMap("InternetSlbSpec")]
        [Validation(Required=false)]
        public string InternetSlbSpec { get; set; }

        /// <summary>
        /// The name of the gateway.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The number of nodes.
        /// </summary>
        [NameInMap("Replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The specifications of the internal-facing Server Load Balancer (SLB) instance. Valid values:
        /// 
        /// *   slb.s1.small
        /// *   slb.s2.small
        /// *   slb.s2.medium
        /// *   slb.s3.small
        /// *   slb.s3.medium
        /// *   slb.s3.large
        /// </summary>
        [NameInMap("SlbSpec")]
        [Validation(Required=false)]
        public string SlbSpec { get; set; }

        /// <summary>
        /// The node specifications. Valid values:
        /// 
        /// *   MSE_GTW\_16\_32\_200\_c(16C32G)
        /// *   MSE_GTW\_2\_4\_200\_c(2C4G)
        /// *   MSE_GTW\_4\_8\_200\_c(4C8G)
        /// *   MSE_GTW\_8\_16\_200\_c(8C16G)
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The tag of the gateway.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddGatewayRequestTag> Tag { get; set; }
        public class AddGatewayRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the primary vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the secondary vSwitch.
        /// </summary>
        [NameInMap("VSwitchId2")]
        [Validation(Required=false)]
        public string VSwitchId2 { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public string Vpc { get; set; }

        /// <summary>
        /// The sample rate of Tracing Analysis. Valid values: \[1,100].
        /// </summary>
        [NameInMap("XtraceRatio")]
        [Validation(Required=false)]
        public string XtraceRatio { get; set; }

    }

}
