// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of flow logs.</para>
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
                /// <para>The sampling interval of the flow log. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AggregationInterval")]
                [Validation(Required=false)]
                public int? AggregationInterval { get; set; }

                /// <summary>
                /// <para>The business status. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: Normal status.</description></item>
                /// <item><description><b>FinancialLocked</b>: Locked due to unpaid bills.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The creation time of the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-21T03:08:50Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>When log delivery fails, you can troubleshoot based on the error messages. Possible error messages include:</para>
                /// <list type="bullet">
                /// <item><description><b>UnavaliableTarget</b>: The Logstore of the Log Service SLS is unavailable and cannot receive logs. It is recommended to check if the corresponding Logstore actually exists and is accessible. </description></item>
                /// <item><description><b>ProjectNotExist</b>: The Project of the Log Service SLS does not exist. It is suggested to delete the original flow log and create a new one pointing to an existing Project. </description></item>
                /// <item><description><b>UnknownError</b>: An internal error has occurred. Please try again later.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UnavaliableTarget</para>
                /// </summary>
                [NameInMap("FlowLogDeliverErrorMessage")]
                [Validation(Required=false)]
                public string FlowLogDeliverErrorMessage { get; set; }

                /// <summary>
                /// <para>The delivery status of the flow log, with values:</para>
                /// <list type="bullet">
                /// <item><description><b>SUCCESS</b>: Delivery succeeded. </description></item>
                /// <item><description><b>FAILED</b>: Delivery failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FAILED</para>
                /// </summary>
                [NameInMap("FlowLogDeliverStatus")]
                [Validation(Required=false)]
                public string FlowLogDeliverStatus { get; set; }

                /// <summary>
                /// <para>The ID of the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fl-bp1f6qqhsrc2c12ta****</para>
                /// </summary>
                [NameInMap("FlowLogId")]
                [Validation(Required=false)]
                public string FlowLogId { get; set; }

                /// <summary>
                /// <para>The name of the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myFlowlog</para>
                /// </summary>
                [NameInMap("FlowLogName")]
                [Validation(Required=false)]
                public string FlowLogName { get; set; }

                /// <summary>
                /// <para>The type of IP address for collecting flow log traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>The Logstore where the captured traffic is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowLogStore</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The Project that manages the captured traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowLogProject</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The region ID to which the flow log belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the flow log belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource ID of the traffic captured by the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-askldfas****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type of the traffic captured by the flow log:</para>
                /// <list type="bullet">
                /// <item><description><b>NetworkInterface</b>: Elastic network interface.</description></item>
                /// <item><description><b>VSwitch</b>: All elastic network interfaces within a VSwitch.</description></item>
                /// <item><description><b>VPC</b>: All elastic network interfaces within a VPC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NetworkInterface</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The hosting type of the cloud service.</para>
                /// <list type="bullet">
                /// <item><description>It can be empty, indicating that the flow log was created by the user. </description></item>
                /// <item><description>When not empty, the only supported value is: <b>sls</b>, indicating that the flow log was created through the Log Service console.<remarks>
                /// <para>Flow log instances created through the Log Service console can be displayed in the VPC list, but they cannot be modified, started, stopped, or deleted within the VPC. If you need to perform these operations on the flow log, you can log in to the <a href="https://sls.console.aliyun.com">Log Service console</a> to modify, start, stop, or delete it.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The status of the flow log. Values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Active</b>: The flow log is in an active state.</para>
                /// </description></item>
                /// <item><description><para><b>Activating</b>: The flow log is being created.</para>
                /// </description></item>
                /// <item><description><para><b>Inactive</b>: The flow log is in an inactive state.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>List of tags</para>
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
                        /// <para>Tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The path of the captured traffic. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>all</b>: Indicates full collection.</description></item>
                /// <item><description><b>internetGateway</b>: Indicates public network traffic collection.</description></item>
                /// </list>
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
                /// <para>The type of traffic captured by the flow log. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>All</b>: All traffic.</description></item>
                /// <item><description><b>Allow</b>: Traffic allowed by access control.</description></item>
                /// <item><description><b>Drop</b>: Traffic denied by access control.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("TrafficType")]
                [Validation(Required=false)]
                public string TrafficType { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of items per page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7DDDC17-FA06-4AC2-8F35-59D2470FCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The number of entries in the queried flow log list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
