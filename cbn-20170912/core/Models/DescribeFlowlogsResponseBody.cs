// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeFlowlogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the flow log.</para>
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
                /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-7qthudw0ll6jmc****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The time when the flow log was created.</para>
                /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-07-24T13:00:52Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myFlowlog</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the flow log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flowlog-m5evbtbpt****</para>
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

                [NameInMap("FlowLogVersion")]
                [Validation(Required=false)]
                public string FlowLogVersion { get; set; }

                /// <summary>
                /// <para>The time window for collecting log data. Unit: seconds. Valid values: <b>60</b> or <b>600</b> Default value: <b>600</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                [NameInMap("LogFormatString")]
                [Validation(Required=false)]
                public string LogFormatString { get; set; }

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
                /// <para>The name of the project that stores the captured traffic data.</para>
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
                /// <para>The status of the flow log. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b>: The flow log is enabled.</description></item>
                /// <item><description><b>Inactive</b>: The flow log is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>A list of tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeFlowlogsResponseBodyFlowLogsFlowLogTags Tags { get; set; }
                public class DescribeFlowlogsResponseBodyFlowLogsFlowLogTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeFlowlogsResponseBodyFlowLogsFlowLogTagsTag> Tag { get; set; }
                    public class DescribeFlowlogsResponseBodyFlowLogsFlowLogTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the network instance connection</para>
                /// 
                /// <b>Example:</b>
                /// <para>tr-attach-5x4o4ynzuqbv6g****</para>
                /// </summary>
                [NameInMap("TransitRouterAttachmentId")]
                [Validation(Required=false)]
                public string TransitRouterAttachmentId { get; set; }

                [NameInMap("TransitRouterId")]
                [Validation(Required=false)]
                public string TransitRouterId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7DDDC17-FA06-4AC2-8F35-59D2470FCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
