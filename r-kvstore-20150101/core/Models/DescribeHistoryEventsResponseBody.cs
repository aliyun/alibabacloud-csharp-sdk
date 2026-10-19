// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
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
                /// <para>The type of the cloud service for the application group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>web</b>: Web applications.</description></item>
                /// <item><description><b>native</b>: Native applications.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("CmsProduct")]
                [Validation(Required=false)]
                public string CmsProduct { get; set; }

                /// <summary>
                /// <para>The type of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The pagination parameter.</para>
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
                /// <para>The end time of the alert.</para>
                /// <para>Specify the time in the YYYY-MM-DDTHH:mm:ssZ format. The time must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-06T11:46:01Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The category of the system event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Exception</b>: Exception events.</description></item>
                /// <item><description><b>Optimize</b>: Optimization events.</description></item>
                /// <item><description><b>Notification</b>: Notification events.</description></item>
                /// <item><description><b>Maintenance</b>: Scheduled O&amp;M events.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exception</para>
                /// </summary>
                [NameInMap("EventCategory")]
                [Validation(Required=false)]
                public string EventCategory { get; set; }

                /// <summary>
                /// <para>The code of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENT000014</para>
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>The details of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                /// <summary>
                /// <para>The ID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>669036</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The impact overview of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// <para>The event level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INFO</b>: Information.</description></item>
                /// <item><description><b>WARN</b>: Warning.</description></item>
                /// <item><description><b>CRITICAL</b>: Critical.</description></item>
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
                /// <para>The status of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Inquiring</b>: Inquiring.</description></item>
                /// <item><description><b>Scheduled</b>: Scheduled.</description></item>
                /// <item><description><b>Running</b>: Running.</description></item>
                /// <item><description><b>Succeed</b>: Succeeded.</description></item>
                /// <item><description><b>Failed</b>: Failed.</description></item>
                /// <item><description><b>Canceled</b>: Canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Succeed</para>
                /// </summary>
                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                /// <summary>
                /// <para>The system event type. Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</description></item>
                /// <item><description><b>SystemMaintenance.Redeploy</b>: Redeployment of the instance due to system maintenance.</description></item>
                /// <item><description><b>SystemFailure.Reboot</b>: The instance is restarted due to a system fault.</description></item>
                /// <item><description><b>SystemFailure.Redeploy</b>: Redeployment of the instance due to a system fault.</description></item>
                /// <item><description><b>SystemFailure.Delete</b>: The instance is released due to a failed creation.</description></item>
                /// <item><description><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance fault.</description></item>
                /// <item><description><b>InstanceExpiration.Stop</b>: The subscription instance is stopped due to expiration.</description></item>
                /// <item><description><b>InstanceExpiration.Delete</b>: The subscription instance is released due to expiration.</description></item>
                /// <item><description><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
                /// <item><description><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>StatusNotification</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The creation time of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-13 05:34:23</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The update time of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-05 10:41:59</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The handling status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>done</para>
                /// </summary>
                [NameInMap("HandleStatus")]
                [Validation(Required=false)]
                public string HandleStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the event has a lifecycle.</para>
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
                /// <para>r-bp15kjsoovqjam****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normandy</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the event is closed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Closed.</description></item>
                /// <item><description><b>1</b>: Open.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                /// <summary>
                /// <para>The name of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kvstore</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b>: Instance resources.</description></item>
                /// <item><description><b>Host</b>: Host resources.</description></item>
                /// <item><description><b>User</b>: User resources.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The type of the source data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// <para>Specify the time in the YYYY-MM-DDTHH:mmZ format. The time must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-30T21:13Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ID of the user to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15532817595*****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4309</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The source of the event.</para>
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
            /// <para>Qitian</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The running duration of the query task. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1734919325126</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27B911BF-4E17-5F8A-A932-79DF2D3F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>430</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
