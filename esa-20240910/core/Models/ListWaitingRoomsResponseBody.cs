// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to trace a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The waiting rooms.</para>
        /// </summary>
        [NameInMap("WaitingRooms")]
        [Validation(Required=false)]
        public List<ListWaitingRoomsResponseBodyWaitingRooms> WaitingRooms { get; set; }
        public class ListWaitingRoomsResponseBodyWaitingRooms : TeaModel {
            /// <summary>
            /// <para>The name of the custom cookie.</para>
            /// 
            /// <b>Example:</b>
            /// <para>__aliwaitingroom_example</para>
            /// </summary>
            [NameInMap("CookieName")]
            [Validation(Required=false)]
            public string CookieName { get; set; }

            /// <summary>
            /// <para>The HTML content or identifier of the custom queuing page. This parameter is valid only when <c>WaitingRoomType</c> is set to <c>custom</c>. The content must be URL-encoded.</para>
            /// </summary>
            [NameInMap("CustomPageHtml")]
            [Validation(Required=false)]
            public string CustomPageHtml { get; set; }

            /// <summary>
            /// <para>The description of the waiting room.</para>
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
            /// <para>on</para>
            /// </summary>
            [NameInMap("DisableSessionRenewalEnable")]
            [Validation(Required=false)]
            public string DisableSessionRenewalEnable { get; set; }

            /// <summary>
            /// <para>Indicates whether the waiting room is enabled. Valid values:</para>
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
            /// <para>The hostname and path.</para>
            /// </summary>
            [NameInMap("HostNameAndPath")]
            [Validation(Required=false)]
            public List<ListWaitingRoomsResponseBodyWaitingRoomsHostNameAndPath> HostNameAndPath { get; set; }
            public class ListWaitingRoomsResponseBodyWaitingRoomsHostNameAndPath : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The subdomain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.</para>
                /// </summary>
                [NameInMap("Subdomain")]
                [Validation(Required=false)]
                public string Subdomain { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether JSON response is enabled. If you set this parameter to on, a JSON body is returned for requests to the waiting room with the header Accept: application/json. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>The name of the waiting room.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The maximum number of new users per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("NewUsersPerMinute")]
            [Validation(Required=false)]
            public string NewUsersPerMinute { get; set; }

            /// <summary>
            /// <para>Indicates whether all requests must be queued. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("QueueAllEnable")]
            [Validation(Required=false)]
            public string QueueAllEnable { get; set; }

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
            /// <para>random</para>
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
            /// <para>The maximum duration for which a session remains valid after a user leaves the origin. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public string SessionDuration { get; set; }

            /// <summary>
            /// <para>The maximum number of active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalActiveUsers")]
            [Validation(Required=false)]
            public string TotalActiveUsers { get; set; }

            /// <summary>
            /// <para>The unique ID of the waiting room.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6a51d5bc6460887abd1291dc7d4d****</para>
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
            /// <para>default</para>
            /// </summary>
            [NameInMap("WaitingRoomType")]
            [Validation(Required=false)]
            public string WaitingRoomType { get; set; }

        }

    }

}
