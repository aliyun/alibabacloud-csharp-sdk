// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeEventsRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID, which is used to filter events of the delivery group. If this parameter is not specified, events are not filtered by delivery group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name. If the name contains only letters, digits, underscores, or hyphens, events are filtered by name prefix. If the name contains spaces or other special characters, events are filtered by the exact value. If this parameter is not specified, events are not filtered by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D workstation group</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The application instance ID, which is used to filter events associated with the instance. If this parameter is not specified, events are not filtered by application instance. To obtain this value, first call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID, and then use the ID as <c>AppInstanceGroupId</c> to call the <a href="~~ListAppInstances~~">ListAppInstances</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-azn3kmwruh1vl****</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// <para>The business region ID of the event, which is used to filter events. If this parameter is not specified, events are not filtered by business region. You can call the <a href="~~ListRegions~~">ListRegions</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end time of the query. <b>Required</b>. The format is the same as <c>StartTime</c>. We recommend that you always include the time zone offset. The query includes this time, and the end time cannot be earlier than <c>StartTime</c>. A time range later than the call time does not generate future events.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-29T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event ID, which is used to query a single event. If this parameter is not specified, events are not filtered by event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>evt-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The event type identifier, which is used to filter events. Different products may generate different event types. This operation does not restrict the value to a fixed enumeration. You should use the <c>EventList.EventType</c> value obtained from previous queries as the filter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SessionDisconnected</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>A compatibility field. The current version does not read this parameter. Use <c>PageSize</c> to control the number of records on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The private IP address of the member elastic network interface (ENI) of the cloud resource, which is used to filter related events. If this parameter is not specified, events are not filtered by IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.10</para>
        /// </summary>
        [NameInMap("MemberEniIp")]
        [Validation(Required=false)]
        public string MemberEniIp { get; set; }

        /// <summary>
        /// <para>A compatibility field. The current version does not read this parameter and does not support token-based pagination. Use <c>PageNumber</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unused</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office network ID, which is used to filter events generated within the office network. If this parameter is not specified, events are not filtered by office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai+dir-123456****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number to query. Pages start from 1. Default value: 1. This parameter is used together with <c>PageSize</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of events to return on each page. Default value: 10. The current operation does not declare a fixed upper limit. We recommend that you set this parameter to a reasonable positive integer based on your actual needs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. The value is case-insensitive. If you specify an unsupported value, the request fails. If this parameter is not specified, events are not filtered by product type. Only the following public product values are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: Wuying Cloud Application.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud Browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise Edition workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Linggou Team Edition container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Linggou Dedicated Edition container workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud Phone.</description></item>
        /// <item><description><c>AIAgent</c>: AgentBay (AI agent).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the query. <b>Required</b>. Use the ISO 8601 format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss</c>. You can include three-digit milliseconds and use <c>Z</c> or <c>±HH:mm</c> to specify the time zone. We recommend that you always include the time zone offset. The query includes this time, and the start time must be earlier than or equal to <c>EndTime</c>. The service only retains and retrieves events that occurred within 30 days before the call time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-28T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The end user ID, which is used to filter events generated by the user. If this parameter is not specified, events are not filtered by user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
