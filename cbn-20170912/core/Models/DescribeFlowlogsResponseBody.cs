// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeFlowlogsResponseBody : TeaModel {
        /// <summary>
        /// The status of the flow log. Valid values:
        /// 
        /// *   **Active**: The flow log is enabled.
        /// *   **Inactive**: The flow log is disabled.
        /// </summary>
        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowlogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowlogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLog")]
            [Validation(Required=false)]
            public List<DescribeFlowlogsResponseBodyFlowLogsFlowLog> FlowLog { get; set; }
            public class DescribeFlowlogsResponseBodyFlowLogsFlowLog : TeaModel {
                /// <summary>
                /// The ID of the region where the flow log is deployed.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The description of the flow log.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the CEN instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time window for collecting log data. Unit: seconds. Valid values: **60** and **600**. Default value: **600**.
                /// </summary>
                [NameInMap("FlowLogId")]
                [Validation(Required=false)]
                public string FlowLogId { get; set; }

                /// <summary>
                /// The name of the project where the flow log is stored.
                /// </summary>
                [NameInMap("FlowLogName")]
                [Validation(Required=false)]
                public string FlowLogName { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// The ID of the flow log.
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// The name of the Logstore where the flow log is stored.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// The ID of the network instance connection.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the flow log.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeFlowlogsResponseBodyFlowLogsFlowLogTags Tags { get; set; }
                public class DescribeFlowlogsResponseBodyFlowLogsFlowLogTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeFlowlogsResponseBodyFlowLogsFlowLogTagsTag> Tag { get; set; }
                    public class DescribeFlowlogsResponseBodyFlowLogsFlowLogTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// A list of tags.
                /// </summary>
                [NameInMap("TransitRouterAttachmentId")]
                [Validation(Required=false)]
                public string TransitRouterAttachmentId { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the flow log.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// A list of flow logs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
