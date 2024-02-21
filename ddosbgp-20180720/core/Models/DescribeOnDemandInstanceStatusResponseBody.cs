// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// The details of the on-demand instance.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeOnDemandInstanceStatusResponseBodyInstances> Instances { get; set; }
        public class DescribeOnDemandInstanceStatusResponseBodyInstances : TeaModel {
            /// <summary>
            /// The details of route advertisement for data centers outside the Chinese mainland. This parameter is a JSON string. The following fields are included in the value:
            /// 
            /// *   **region**: The code of the data center outside the Chinese mainland. The value is of the STRING type. For more information, see **Codes of data centers outside the Chinese mainland**.
            /// *   **declared**: indicates whether the data center advertised the route. The value is of the STRING type. Valid values: **0** and **1**. The value of 0 indicates that the data center did not advertise the route. The value of 1 indicates that the data center advertised the route.
            /// </summary>
            [NameInMap("Declared")]
            [Validation(Required=false)]
            public string Declared { get; set; }

            /// <summary>
            /// The description of the on-demand instance.
            /// 
            /// >  The value of this parameter is returned only when the information about multiple on-demand instances is returned. The value of this parameter is not returned because the information about only one on-demand instance is returned.
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The ID of the on-demand instance.
            /// 
            /// >  The value of this parameter is returned only when the information about multiple on-demand instances is returned. The value of this parameter is not returned because the information about only one on-demand instance is returned.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The mode used to start the on-demand instance. Valid values:
            /// 
            /// *   **manual**: The instance is manually started.
            /// *   **netflow-auto**: The instance is automatically started by using NetFlow that monitors network traffic.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The CIDR block of the on-demand instance.
            /// </summary>
            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

            /// <summary>
            /// The number of the autonomous system (AS). Set the value to **0**, which indicates that AS is disabled.
            /// </summary>
            [NameInMap("RegistedAs")]
            [Validation(Required=false)]
            public string RegistedAs { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
