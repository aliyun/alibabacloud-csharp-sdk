// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRiskLevelsResponseBody : TeaModel {
        /// <summary>
        /// The information about the instances.
        /// </summary>
        [NameInMap("InstanceRisks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRiskLevelsResponseBodyInstanceRisks> InstanceRisks { get; set; }
        public class DescribeInstanceRiskLevelsResponseBodyInstanceRisks : TeaModel {
            /// <summary>
            /// The risk levels of the Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeInstanceRiskLevelsResponseBodyInstanceRisksDetails> Details { get; set; }
            public class DescribeInstanceRiskLevelsResponseBodyInstanceRisksDetails : TeaModel {
                /// <summary>
                /// The IP addresses of servers.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The risk levels. Valid values:
                /// 
                /// *   **medium**
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The instance ID of your Cloud Firewall.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The risk levels. Valid values:
            /// 
            /// *   **medium**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
