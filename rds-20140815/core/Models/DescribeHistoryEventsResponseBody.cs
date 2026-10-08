// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The event list.</para>
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
                /// <para>The cloud service type of the application group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>web</b>: web application.</description></item>
                /// <item><description><b>native</b>: on-premises application.</description></item>
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
                /// <para>The pagination parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DetailImpact")]
                [Validation(Required=false)]
                public string DetailImpact { get; set; }

                /// <summary>
                /// <para>The instance operation details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("DetailReason")]
                [Validation(Required=false)]
                public string DetailReason { get; set; }

                /// <summary>
                /// <para>The alert end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-06T11:46:01Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The system event categorization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Exception</b>: abnormal event.</description></item>
                /// <item><description><b>Optimize</b>: optimization events.</description></item>
                /// <item><description><b>Notification</b>: notification event.</description></item>
                /// <item><description><b>Maintenance</b>: scheduled maintenance event.</description></item>
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
                /// <para>ENT000014</para>
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>The event details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>669036</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The event impact overview.</para>
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
                /// <item><description><b>INFO</b>: notification.</description></item>
                /// <item><description><b>WARN</b>: warning.</description></item>
                /// <item><description><b>CRITICAL</b>: critical.</description></item>
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
                /// <item><description><b>Inquiring</b>: inquiring.</description></item>
                /// <item><description><b>Scheduled</b>: scheduled.</description></item>
                /// <item><description><b>Running</b>: running.</description></item>
                /// <item><description><b>Succeed</b>: completed.</description></item>
                /// <item><description><b>Failed</b>: failed.</description></item>
                /// <item><description><b>Canceled</b>: canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                /// <summary>
                /// <para>The system event type. Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</description></item>
                /// <item><description><b>SystemMaintenance.Redeploy</b>: The instance is redeployed due to system maintenance.</description></item>
                /// <item><description><b>SystemFailure.Reboot</b>: The instance is restarted due to a system error.</description></item>
                /// <item><description><b>SystemFailure.Redeploy</b>: The instance is redeployed due to a system error.</description></item>
                /// <item><description><b>SystemFailure.Delete</b>: The instance is released due to an instance creation failure.</description></item>
                /// <item><description><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance error.</description></item>
                /// <item><description><b>InstanceExpiration.Stop</b>: The instance is stopped due to subscription expiration.</description></item>
                /// <item><description><b>InstanceExpiration.Delete</b>: The instance is released due to subscription expiration.</description></item>
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
                /// <para>The time when the event was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-17T16:05:40Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the event was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-14T09:44:39.000+0000</para>
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
                /// <para>rg-acfmy****</para>
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
                /// <para>Indicates whether the event is closed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: closed.</description></item>
                /// <item><description><b>1</b>: open.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                /// <summary>
                /// <para>The product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-guangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b>: instance resource.</description></item>
                /// <item><description><b>Host</b>: host resource.</description></item>
                /// <item><description><b>User</b>: user resource.</description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-29T07:23Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who owns the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16986832xxxxx</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
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
            /// <para>cn-beijing</para>
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
            /// <para>The elapsed time of the query task. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1675232573125</para>
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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A41C147-C8D0-4DAE-A1A2-17EBCD60DFA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
