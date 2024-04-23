// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRiskLevelsRequest : TeaModel {
        /// <summary>
        /// The information about the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstanceRiskLevelsRequestInstances> Instances { get; set; }
        public class DescribeInstanceRiskLevelsRequestInstances : TeaModel {
            /// <summary>
            /// The instance ID of your Cloud Firewall.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The public IP addresses of instances.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public List<string> InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the instance.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The UUID of the instance.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
