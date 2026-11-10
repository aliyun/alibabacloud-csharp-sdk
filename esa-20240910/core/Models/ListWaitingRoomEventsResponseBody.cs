// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f3c3700a-4c0f-4a24-b576-fd7dbf9e7c55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of waiting room events, which contains the specific information of each event.</para>
        /// </summary>
        [NameInMap("WaitingRoomEvents")]
        [Validation(Required=false)]
        public List<ListWaitingRoomEventsResponseBodyWaitingRoomEvents> WaitingRoomEvents { get; set; }
        public class ListWaitingRoomEventsResponseBodyWaitingRoomEvents : TeaModel {
            /// <summary>
            /// <para>The custom content of the waiting room page. This parameter is required when the waiting room type is custom. The content must be URL-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>html-yets-maqi1111</para>
            /// </summary>
            [NameInMap("CustomPageHtml")]
            [Validation(Required=false)]
            public string CustomPageHtml { get; set; }

            /// <summary>
            /// <para>The detailed description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>terraform-example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether session renewal is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DisableSessionRenewalEnable")]
            [Validation(Required=false)]
            public string DisableSessionRenewalEnable { get; set; }

            /// <summary>
            /// <para>The enabled status of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The end time of the event. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719814497</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable JSON responses. If this feature is enabled and the Accept request header contains &quot;application/json&quot;, JSON data is returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("JsonResponseEnable")]
            [Validation(Required=false)]
            public string JsonResponseEnable { get; set; }

            /// <summary>
            /// <para>The language of the waiting room page. This parameter is required when the waiting room type is default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enus</b>: English.</description></item>
            /// <item><description><b>zhcn</b>: Simplified Chinese.</description></item>
            /// <item><description><b>zhhk</b>: Traditional Chinese.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zhcn</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The event name, which is a custom event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test event</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of new users per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("NewUsersPerMinute")]
            [Validation(Required=false)]
            public string NewUsersPerMinute { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable pre-queuing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PreQueueEnable")]
            [Validation(Required=false)]
            public string PreQueueEnable { get; set; }

            /// <summary>
            /// <para>The start time of pre-queuing. The value is a UNIX timestamp. This parameter is valid only when pre-queuing is enabled.</para>
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
            /// <item><description><b>random</b>: Random.</description></item>
            /// <item><description><b>fifo</b>: First-in, first-out (FIFO).</description></item>
            /// <item><description><b>passthrough</b>: Passthrough.</description></item>
            /// <item><description><b>reject-all</b>: Reject all.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fifo</para>
            /// </summary>
            [NameInMap("QueuingMethod")]
            [Validation(Required=false)]
            public string QueuingMethod { get; set; }

            /// <summary>
            /// <para>The waiting room status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>200</b></description></item>
            /// <item><description><b>202</b></description></item>
            /// <item><description><b>429</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("QueuingStatusCode")]
            [Validation(Required=false)]
            public string QueuingStatusCode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable random pre-queuing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RandomPreQueueEnable")]
            [Validation(Required=false)]
            public string RandomPreQueueEnable { get; set; }

            /// <summary>
            /// <para>The session duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public string SessionDuration { get; set; }

            /// <summary>
            /// <para>The start time of the event. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719814398</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The total number of active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalActiveUsers")]
            [Validation(Required=false)]
            public string TotalActiveUsers { get; set; }

            /// <summary>
            /// <para>The event ID, which uniquely identifies a waiting room event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89677721098****</para>
            /// </summary>
            [NameInMap("WaitingRoomEventId")]
            [Validation(Required=false)]
            public long? WaitingRoomEventId { get; set; }

            /// <summary>
            /// <para>The ID of the associated waiting room.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c938a045c9ca46607163d34966****</para>
            /// </summary>
            [NameInMap("WaitingRoomId")]
            [Validation(Required=false)]
            public string WaitingRoomId { get; set; }

            /// <summary>
            /// <para>The waiting room type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: Default type.</description></item>
            /// <item><description><b>custom</b>: Custom type.</description></item>
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
