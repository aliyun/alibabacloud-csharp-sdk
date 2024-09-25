// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the flow logs.</para>
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
                /// <para>The business status of the flow log. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>FinancialLocked</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The time when the flow log was created.</para>
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
                /// <para>If the flow log failed to be delivered, you can troubleshoot based on the following error messages that may be returned:</para>
                /// <list type="bullet">
                /// <item><description><b>UnavaliableTarget</b>: The Logstore of SLS is unavailable and cannot receive logs. Check whether the Logstore is available.</description></item>
                /// <item><description><b>ProjectNotExist</b>: The project of SLS does not exist. We recommend that you delete the project and create a new one.</description></item>
                /// <item><description><b>UnknownError</b>: An internal error occurred. Try again later.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UnavaliableTarget</para>
                /// </summary>
                [NameInMap("FlowLogDeliverErrorMessage")]
                [Validation(Required=false)]
                public string FlowLogDeliverErrorMessage { get; set; }

                /// <summary>
                /// <para>Indicates whether the flow log is delivered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SUCCESS</b> </description></item>
                /// <item><description><b>FAILED</b></description></item>
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

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>The Logstore that stores the captured traffic data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowLogStore</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The project that manages the captured traffic data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowLogProject</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The region ID of the flow log.</para>
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
                /// <para>The ID of the resource from which traffic is captured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-askldfas****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource from which traffic is captured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NetworkInterface</b>: ENI</description></item>
                /// <item><description><b>VSwitch</b>: all ENIs in a vSwitch</description></item>
                /// <item><description><b>VPC</b>: all ENIs in a VPC</description></item>
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
                /// <item><description>This parameter can be empty, which indicates that the flow log is created by the user.</description></item>
                /// <item><description>If this parameter is not empty, the value is set to <b>sls</b>. The value sls indicates that the flow log is created in the Simple Log Service (SLS) console.</description></item>
                /// </list>
                /// <remarks>
                /// <para>A flow log that is created in the SLS console can be displayed in the VPC list. However, you cannot modify, start, stop, or delete the flow log in the VPC console. If you want to manage the flow log, you can log on to the <a href="https://sls.console.aliyun.com">SLS console</a> and perform required operations.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The status of the flow log. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b></description></item>
                /// <item><description><b>Activating</b></description></item>
                /// <item><description><b>Inactive</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of tags.</para>
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
                        /// <para>The key of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N.</para>
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
                /// <para>The sampling scope of the traffic that is collected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>all</b> (default value): all traffic</description></item>
                /// <item><description><b>internetGateway</b>: Internet traffic</description></item>
                /// </list>
                /// <remarks>
                /// <para>By default, the traffic path feature is unavailable. To use this feature, <a href="https://workorder-intl.console.aliyun.com/?spm=5176.11182188.console-base-top.dworkorder.18ae4882n3v6ZW#/ticket/createIndex">submit a ticket</a>.</para>
                /// </remarks>
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
                /// <para>The type of traffic that is captured by the flow log. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>All</b>: all traffic</description></item>
                /// <item><description><b>Allow</b>: traffic that is allowed by access control</description></item>
                /// <item><description><b>Drop</b>: traffic that is denied by access control</description></item>
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
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The number of flow logs that are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
