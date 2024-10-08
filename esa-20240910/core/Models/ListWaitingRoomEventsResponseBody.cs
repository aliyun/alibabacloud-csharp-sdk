// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>f3c3700a-4c0f-4a24-b576-fd7dbf9e7c55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WaitingRoomEvents")]
        [Validation(Required=false)]
        public List<ListWaitingRoomEventsResponseBodyWaitingRoomEvents> WaitingRoomEvents { get; set; }
        public class ListWaitingRoomEventsResponseBodyWaitingRoomEvents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>html-yets-maqi1111</para>
            /// </summary>
            [NameInMap("CustomPageHtml")]
            [Validation(Required=false)]
            public string CustomPageHtml { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>terraform-example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DisableSessionRenewalEnable")]
            [Validation(Required=false)]
            public string DisableSessionRenewalEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719814497</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("JsonResponseEnable")]
            [Validation(Required=false)]
            public string JsonResponseEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhcn</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("NewUsersPerMinute")]
            [Validation(Required=false)]
            public string NewUsersPerMinute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PreQueueEnable")]
            [Validation(Required=false)]
            public string PreQueueEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719814097</para>
            /// </summary>
            [NameInMap("PreQueueStartTime")]
            [Validation(Required=false)]
            public string PreQueueStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fifo</para>
            /// </summary>
            [NameInMap("QueuingMethod")]
            [Validation(Required=false)]
            public string QueuingMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("QueuingStatusCode")]
            [Validation(Required=false)]
            public string QueuingStatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RandomPreQueueEnable")]
            [Validation(Required=false)]
            public string RandomPreQueueEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public string SessionDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719814398</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalActiveUsers")]
            [Validation(Required=false)]
            public string TotalActiveUsers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>89677721098****</para>
            /// </summary>
            [NameInMap("WaitingRoomEventId")]
            [Validation(Required=false)]
            public long? WaitingRoomEventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5c938a045c9ca46607163d34966****</para>
            /// </summary>
            [NameInMap("WaitingRoomId")]
            [Validation(Required=false)]
            public string WaitingRoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("WaitingRoomType")]
            [Validation(Required=false)]
            public string WaitingRoomType { get; set; }

        }

    }

}
