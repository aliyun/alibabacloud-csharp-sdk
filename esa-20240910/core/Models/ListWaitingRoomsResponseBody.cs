// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to trace API calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of waiting rooms.</para>
        /// </summary>
        [NameInMap("WaitingRooms")]
        [Validation(Required=false)]
        public List<ListWaitingRoomsResponseBodyWaitingRooms> WaitingRooms { get; set; }
        public class ListWaitingRoomsResponseBodyWaitingRooms : TeaModel {
            /// <summary>
            /// <para>The custom cookie name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>__aliwaitingroom_example</para>
            /// </summary>
            [NameInMap("CookieName")]
            [Validation(Required=false)]
            public string CookieName { get; set; }

            /// <summary>
            /// <para>The HTML content or identifier of the custom queuing page. This parameter is valid only when WaitingRoomType is set to custom. The content must be URL-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom HTML content</para>
            /// </summary>
            [NameInMap("CustomPageHtml")]
            [Validation(Required=false)]
            public string CustomPageHtml { get; set; }

            /// <summary>
            /// <para>The waiting room description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test waiting room</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable session renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DisableSessionRenewalEnable")]
            [Validation(Required=false)]
            public string DisableSessionRenewalEnable { get; set; }

            /// <summary>
            /// <para>The enabled status. Valid values:</para>
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
            /// <para>The hostname and path configurations.</para>
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
            /// <para>Specifies whether to enable JSON response. When enabled, requests with an Accept header containing &quot;application/json&quot; return JSON data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>The waiting room name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test waiting room</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of new users per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("NewUsersPerMinute")]
            [Validation(Required=false)]
            public string NewUsersPerMinute { get; set; }

            /// <summary>
            /// <para>Specifies whether to queue all visitors. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
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
            /// <item><description><b>random</b>: Random.</description></item>
            /// <item><description><b>fifo</b>: First in, first out.</description></item>
            /// <item><description><b>passthrough</b>: Passthrough.</description></item>
            /// <item><description><b>reject-all</b>: Reject all.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>random</para>
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
            /// <para>The session duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public string SessionDuration { get; set; }

            /// <summary>
            /// <para>The total number of active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalActiveUsers")]
            [Validation(Required=false)]
            public string TotalActiveUsers { get; set; }

            /// <summary>
            /// <para>The waiting room ID, which uniquely identifies a waiting room.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6a51d5bc6460887abd1291dc7d4d****</para>
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
            /// <para>default</para>
            /// </summary>
            [NameInMap("WaitingRoomType")]
            [Validation(Required=false)]
            public string WaitingRoomType { get; set; }

        }

    }

}
