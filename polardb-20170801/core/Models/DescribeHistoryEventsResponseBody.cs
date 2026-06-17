// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The data overview.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeHistoryEventsResponseBodyItemsData Data { get; set; }
            public class DescribeHistoryEventsResponseBodyItemsData : TeaModel {
                /// <summary>
                /// <para>The type of the Alibaba Cloud service for the application group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>web</b>: web application.</para>
                /// </description></item>
                /// <item><description><para><b>native</b>: native application.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("CmsProduct")]
                [Validation(Required=false)]
                public string CmsProduct { get; set; }

                /// <summary>
                /// <para>The database type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>This parameter is used for pagination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DetailImpact")]
                [Validation(Required=false)]
                public string DetailImpact { get; set; }

                /// <summary>
                /// <para>The details of the instance operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("DetailReason")]
                [Validation(Required=false)]
                public string DetailReason { get; set; }

                /// <summary>
                /// <para>The end of the query time range. The end time must be later than the start time. The interval between the start time and the end time must be within 24 hours. The time is in the <c>YYYY-MM-DDThh:mmZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-24T02:24:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The category of the system event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Exception</b>: anomalous activity</para>
                /// </description></item>
                /// <item><description><para><b>Optimize</b>: optimization events</para>
                /// </description></item>
                /// <item><description><para><b>Notification</b>: notification events</para>
                /// </description></item>
                /// <item><description><para><b>Maintenance</b>: scheduled O\&amp;M events</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exception</para>
                /// </summary>
                [NameInMap("EventCategory")]
                [Validation(Required=false)]
                public string EventCategory { get; set; }

                /// <summary>
                /// <para>The event code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de_aamexg3015</para>
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>The event details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600324</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>An overview of the event\&quot;s impact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// <para>The event level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>INFO</b>: notification</para>
                /// </description></item>
                /// <item><description><para><b>WARN</b>: warning</para>
                /// </description></item>
                /// <item><description><para><b>CRITICAL</b>: urgent</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// <para>The source of the event operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// <para>The event status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Inquiring</b>: The event is being inquired.</para>
                /// </description></item>
                /// <item><description><para><b>Scheduled</b>: The event is scheduled.</para>
                /// </description></item>
                /// <item><description><para><b>Running</b>: The event is in progress.</para>
                /// </description></item>
                /// <item><description><para><b>Succeed</b>: The event is successful.</para>
                /// </description></item>
                /// <item><description><para><b>Failed</b>: The event failed.</para>
                /// </description></item>
                /// <item><description><para><b>Canceled</b>: The event is canceled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Inquiring</para>
                /// </summary>
                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                /// <summary>
                /// <para>The type of the system event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</para>
                /// </description></item>
                /// <item><description><para><b>SystemMaintenance.Redeploy</b>: The instance is redeployed due to system maintenance.</para>
                /// </description></item>
                /// <item><description><para><b>SystemFailure.Reboot</b>: The instance is restarted due to a system fault.</para>
                /// </description></item>
                /// <item><description><para><b>SystemFailure.Redeploy</b>: The instance is redeployed due to a system fault.</para>
                /// </description></item>
                /// <item><description><para><b>SystemFailure.Delete</b>: The instance is released because it failed to be created.</para>
                /// </description></item>
                /// <item><description><para><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance fault.</para>
                /// </description></item>
                /// <item><description><para><b>InstanceExpiration.Stop</b>: The subscription instance is stopped because its subscription expires.</para>
                /// </description></item>
                /// <item><description><para><b>InstanceExpiration.Delete</b>: The subscription instance is released because its subscription expires.</para>
                /// </description></item>
                /// <item><description><para><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</para>
                /// </description></item>
                /// <item><description><para><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SystemFailure.Delete</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-15T14:53:06+08:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-07T15:10:32+08:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The processing status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>done</para>
                /// </summary>
                [NameInMap("HandleStatus")]
                [Validation(Required=false)]
                public string HandleStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether a lifecycle exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasLifeCycle")]
                [Validation(Required=false)]
                public int? HasLifeCycle { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-2ze150h1p29t***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dhimgsearch</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the event is successfully closed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: closed</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: open</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                /// <summary>
                /// <para>The product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polardb</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Instance</b>: instance resource</para>
                /// </description></item>
                /// <item><description><para><b>Host</b>: host resource</para>
                /// </description></item>
                /// <item><description><para><b>User</b>: user resource</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The type of the source data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>loanBill</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The start of the query time range. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-27T02:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ID of the user to whom the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1540497309282125</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the region where the task is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The event source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>loanBill</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The database version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("Specversion")]
            [Validation(Required=false)]
            public string Specversion { get; set; }

            /// <summary>
            /// <para>The name of the pending event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QiTian</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The runtime of the query task. Unit: seconds (s).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758680209206</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB07CFF0-D8A4-5C76-AED7-D00E26FC2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
