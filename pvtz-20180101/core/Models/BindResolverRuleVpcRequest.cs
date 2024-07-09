// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class BindResolverRuleVpcRequest : TeaModel {
        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The forwarding rule ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The VPCs.
        /// </summary>
        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public List<BindResolverRuleVpcRequestVpc> Vpc { get; set; }
        public class BindResolverRuleVpcRequestVpc : TeaModel {
            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The VPC ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The VPC type. Valid values:
            /// 
            /// *   STANDARD: standard VPC
            /// *   EDS: Elastic Desktop Service (EDS) workspace VPC
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

        }

    }

}
