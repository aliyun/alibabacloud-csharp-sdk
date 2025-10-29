// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsResponseBodyEvents> Events { get; set; }
        public class DescribeHistoryEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-d71ff150945b9c02eb6ebc0016328468</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The level of the specific event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CRITICAL</description></item>
            /// <item><description>WARN</description></item>
            /// <item><description>INFO</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARN</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The status of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Inquiring</description></item>
            /// <item><description>Scheduled</description></item>
            /// <item><description>Executing</description></item>
            /// <item><description>Executed</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Canceled</description></item>
            /// <item><description>Avoided</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inquiring</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            /// <summary>
            /// <para>The type of the event. Description:</para>
            /// <list type="bullet">
            /// <item><description>Instance:SystemFailure.Redeploy: The instance is redeployed due to system issues.</description></item>
            /// <item><description>Instance:SystemFailure.Reboot: The instance is restarted due to a system error.</description></item>
            /// <item><description>Instance:RegionNetworkDown: The node network is interrupted.</description></item>
            /// <item><description>Disk:Stalled: The disk performance is impaired.</description></item>
            /// <item><description>EnsRegion:NetworkMigration: The instance is migrated due to a system error.</description></item>
            /// <item><description>IP:SafeRisk: IP alerts.</description></item>
            /// <item><description>IP:SafeBan: IP blocking.</description></item>
            /// <item><description>Instance:SystemUpgrade.Migrate: The instance needs to be migrated due to underlying upgrades.</description></item>
            /// <item><description>Instance:SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instance:SystemFailure.Reboot</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The extended attributes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtendedAttribute")]
            [Validation(Required=false)]
            public string ExtendedAttribute { get; set; }

            /// <summary>
            /// <para>The scheduled execution time of the event in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715578245000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <para>The release time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715578245000</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public long? PublishTime { get; set; }

            /// <summary>
            /// <para>The event cause.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The ID of the associated resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-55qi8m11rr53c4i964md8a00l</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5359599C-F656-57BD-8A0D-329A2FD511A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
