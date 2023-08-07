// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        /// <summary>
        /// The information about the flow logs.
        /// </summary>
        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowLogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowLogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLog")]
            [Validation(Required=false)]
            public List<DescribeFlowLogsResponseBodyFlowLogsFlowLog> FlowLog { get; set; }
            public class DescribeFlowLogsResponseBodyFlowLogsFlowLog : TeaModel {
                /// <summary>
                /// The sampling interval of the flow log. Unit: seconds.
                /// </summary>
                [NameInMap("AggregationInterval")]
                [Validation(Required=false)]
                public int? AggregationInterval { get; set; }

                /// <summary>
                /// The business status of the flow log. Valid values:
                /// 
                /// *   **Normal**: active
                /// *   **FinancialLocked**: locked due to overdue payments
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The time when the flow log was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the flow log.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FlowLogDeliverErrorMessage")]
                [Validation(Required=false)]
                public string FlowLogDeliverErrorMessage { get; set; }

                [NameInMap("FlowLogDeliverStatus")]
                [Validation(Required=false)]
                public string FlowLogDeliverStatus { get; set; }

                /// <summary>
                /// The ID of the flow log.
                /// </summary>
                [NameInMap("FlowLogId")]
                [Validation(Required=false)]
                public string FlowLogId { get; set; }

                /// <summary>
                /// The name of the flow log.
                /// </summary>
                [NameInMap("FlowLogName")]
                [Validation(Required=false)]
                public string FlowLogName { get; set; }

                /// <summary>
                /// The Logstore that stores the captured traffic data.
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// The project that manages the captured traffic data.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// The region ID of the flow log.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the flow log belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the resource from which traffic is captured.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the resource from which traffic is captured. Valid values:
                /// 
                /// *   **NetworkInterface**: an ENI
                /// *   **VSwitch**: all ENIs in a vSwitch
                /// *   **VPC**: all ENIs in a VPC
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The hosting type of the cloud service.
                /// 
                /// *   This parameter can be empty, which indicates that the flow log is created by the user.
                /// *   If this parameter is not empty, the value is fixed as **sls**. The value sls indicates that the flow log is created in the Log Service console.
                /// 
                /// >  A flow log that is created in the Log Service console can be displayed in the VPC list. However, you cannot modify, start, stop, or delete the flow log in the VPC console. If you want to manage the flow log, you can log on to the [Log Service console](https://sls.console.aliyun.com) and perform required operations.
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// The status of the flow log. Valid values:
                /// 
                /// *   **Active**: enabled
                /// *   **Activating**: being enabled
                /// *   **Inactive**: disabled
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// An array that consists of the details of the returned tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeFlowLogsResponseBodyFlowLogsFlowLogTags Tags { get; set; }
                public class DescribeFlowLogsResponseBodyFlowLogsFlowLogTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeFlowLogsResponseBodyFlowLogsFlowLogTagsTag> Tag { get; set; }
                    public class DescribeFlowLogsResponseBodyFlowLogsFlowLogTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The scope of the traffic that you want to capture. Valid values:
                /// 
                /// *   **all** (default value): all traffic
                /// *   **internetGateway**: Internet traffic
                /// 
                /// >  By default, the traffic path feature is unavailable. To use this feature, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.11182188.console-base-top.dworkorder.18ae4882n3v6ZW#/ticket/createIndex).
                /// </summary>
                [NameInMap("TrafficPath")]
                [Validation(Required=false)]
                public DescribeFlowLogsResponseBodyFlowLogsFlowLogTrafficPath TrafficPath { get; set; }
                public class DescribeFlowLogsResponseBodyFlowLogsFlowLogTrafficPath : TeaModel {
                    [NameInMap("TrafficPathList")]
                    [Validation(Required=false)]
                    public List<string> TrafficPathList { get; set; }

                }

                /// <summary>
                /// The type of traffic that is captured by the flow log. Valid values:
                /// 
                /// *   **All**: all traffic
                /// *   **Allow**: traffic that is allowed by access control
                /// *   **Drop**: traffic that is denied by access control
                /// </summary>
                [NameInMap("TrafficType")]
                [Validation(Required=false)]
                public string TrafficType { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The number of flow logs that are queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
