// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to trace a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f3c3700a-4c0f-4a24-b576-fd7dbf9e7c55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the waiting room events.</para>
        /// </summary>
        [NameInMap("WaitingRoomEvents")]
        [Validation(Required=false)]
        public List<ListWaitingRoomEventsResponseBodyWaitingRoomEvents> WaitingRoomEvents { get; set; }
        public class ListWaitingRoomEventsResponseBodyWaitingRoomEvents : TeaModel {
            /// <summary>
            /// <para>The content of the custom waiting room page. This parameter is returned when the waiting room type is set to custom. The content is URL-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>html-yets-maqi1111</para>
            /// </summary>
            [NameInMap("CustomPageHtml")]
            [Validation(Required=false)]
            public string CustomPageHtml { get; set; }

            /// <summary>
            /// <para>The event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>terraform-example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether session renewal is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DisableSessionRenewalEnable")]
            [Validation(Required=false)]
            public string DisableSessionRenewalEnable { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The end time of the event. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719814497</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether JOSN response is enabled. If JSON response is enabled, a JSON body is returned for requests to the waiting room with the header Accept: application/json. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("JsonResponseEnable")]
            [Validation(Required=false)]
            public string JsonResponseEnable { get; set; }

            /// <summary>
            /// <para>The language of the waiting room page. This parameter is returned when the waiting room type is set to default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enus: English.</description></item>
            /// <item><description>zhcn: Simplified Chinese.</description></item>
            /// <item><description>zhhk: Traditional Chinese.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zhcn</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The custom event name.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The maximum number of new users per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("NewUsersPerMinute")]
            [Validation(Required=false)]
            public string NewUsersPerMinute { get; set; }

            /// <summary>
            /// <para>Indicates whether pre-queuing is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PreQueueEnable")]
            [Validation(Required=false)]
            public string PreQueueEnable { get; set; }

            /// <summary>
            /// <para>The start time for pre-queuing. This value is a UNIX timestamp. This parameter is valid only when pre-queuing is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719814097</para>
            /// </summary>
            [NameInMap("PreQueueStartTime")]
            [Validation(Required=false)]
            public string PreQueueStartTime { get; set; }

            /// <summary>
            /// <para>The queuing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>random: Users gain access to the origin randomly, regardless of the arrival time.</description></item>
            /// <item><description>fifo: Users gain access to the origin in order of arrival.</description></item>
            /// <item><description>passthrough: Users pass through the waiting room and go straight to the origin.</description></item>
            /// <item><description>reject-all: Users are blocked from reaching the origin.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fifo</para>
            /// </summary>
            [NameInMap("QueuingMethod")]
            [Validation(Required=false)]
            public string QueuingMethod { get; set; }

            /// <summary>
            /// <para>The HTTP status code to return while a user is in the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>200</description></item>
            /// <item><description>202</description></item>
            /// <item><description>429</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("QueuingStatusCode")]
            [Validation(Required=false)]
            public string QueuingStatusCode { get; set; }

            /// <summary>
            /// <para>Indicates whether random queuing is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RandomPreQueueEnable")]
            [Validation(Required=false)]
            public string RandomPreQueueEnable { get; set; }

            /// <summary>
            /// <para>The maximum duration for which a session remains valid after a user leaves the origin. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public string SessionDuration { get; set; }

            /// <summary>
            /// <para>The start time of the event. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719814398</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The maximum number of active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalActiveUsers")]
            [Validation(Required=false)]
            public string TotalActiveUsers { get; set; }

            /// <summary>
            /// <para>The unique ID of the waiting room event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89677721098****</para>
            /// </summary>
            [NameInMap("WaitingRoomEventId")]
            [Validation(Required=false)]
            public long? WaitingRoomEventId { get; set; }

            /// <summary>
            /// <para>The ID of the waiting room associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c938a045c9ca46607163d34966****</para>
            /// </summary>
            [NameInMap("WaitingRoomId")]
            [Validation(Required=false)]
            public string WaitingRoomId { get; set; }

            /// <summary>
            /// <para>The type of the waiting room. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default</description></item>
            /// <item><description>custom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("WaitingRoomType")]
            [Validation(Required=false)]
            public string WaitingRoomType { get; set; }

        }

    }

}
