// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlockStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of details of the Diversion from Origin Server configurations of the instance.
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<DescribeBlockStatusResponseBodyStatusList> StatusList { get; set; }
        public class DescribeBlockStatusResponseBodyStatusList : TeaModel {
            /// <summary>
            /// An array that consists of details of the Diversion from Origin Server configuration.
            /// </summary>
            [NameInMap("BlockStatusList")]
            [Validation(Required=false)]
            public List<DescribeBlockStatusResponseBodyStatusListBlockStatusList> BlockStatusList { get; set; }
            public class DescribeBlockStatusResponseBodyStatusListBlockStatusList : TeaModel {
                /// <summary>
                /// The blocking status of the network traffic. Valid values:
                /// 
                /// *   **areablock**: Network traffic is blocked.
                /// *   **normal**: Network traffic is not blocked.
                /// </summary>
                [NameInMap("BlockStatus")]
                [Validation(Required=false)]
                public string BlockStatus { get; set; }

                /// <summary>
                /// The end time of the blocking. This value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The Internet service provider (ISP) line from which the traffic is blocked. Valid values:
                /// 
                /// *   **ct**: China Telecom (International)
                /// *   **cut**: China Unicom (International)
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// The start time of the blocking. This value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
