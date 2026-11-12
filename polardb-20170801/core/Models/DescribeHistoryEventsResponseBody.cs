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
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The data overview.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeHistoryEventsResponseBodyItemsData Data { get; set; }
            public class DescribeHistoryEventsResponseBodyItemsData : TeaModel {
                /// <summary>
                /// <para>The cloud service type of the application group. Valid values:</para>
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
                /// <para>mysql</para>
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
                /// <para>The instance needs to be restarted due to system maintenance</para>
                /// </summary>
                [NameInMap("DetailReason")]
                [Validation(Required=false)]
                public string DetailReason { get; set; }

                /// <summary>
                /// <para>The end time of the query. The end time must be later than the start time, and the interval between the start time and the end time must be within 24 hours. Specify the time in the <c>YYYY-MM-DDThh:mmZ</c> format (UTC time).</para>
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
                /// <para>The instance will be restarted within the maintenance window</para>
                /// </summary>
                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                /// <summary>
                /// <para>The ID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600324</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The impact overview of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The instance connection may be briefly interrupted</para>
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// <para>The event level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INFO</b>: Notification.</description></item>
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
                /// <para>System maintenance</para>
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
                /// <para>Inquiring</para>
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
                /// <item><description><b>SystemFailure.Delete</b>: The instance is released because instance creation failed.</description></item>
                /// <item><description><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance fault.</description></item>
                /// <item><description><b>InstanceExpiration.Stop</b>: The subscription instance is stopped due to expiration.</description></item>
                /// <item><description><b>InstanceExpiration.Delete</b>: The subscription instance is released due to expiration.</description></item>
                /// <item><description><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
                /// <item><description><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.</description></item>
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
                /// <para>0</para>
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
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dhimgsearch</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the item is closed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Closed.</description></item>
                /// <item><description><b>1</b>: Open.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                /// <summary>
                /// <para>The name of the product.</para>
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
                /// <para>The type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b>: Instance resources.</description></item>
                /// <item><description><b>Host</b>: Host resources.</description></item>
                /// <item><description><b>User</b>: User resources.</description></item>
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
                /// <para>The start time of the query. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-27T02:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ID of the user to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1540497309282125</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The region ID of the region where the task is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
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
            /// <para>The name of the event to be processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QiTian</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The running time of the queried task. Unit: seconds.</para>
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
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB07CFF0-D8A4-5C76-AED7-D00E26FC2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
