// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WaitingRooms")]
        [Validation(Required=false)]
        public List<ListWaitingRoomsResponseBodyWaitingRooms> WaitingRooms { get; set; }
        public class ListWaitingRoomsResponseBodyWaitingRooms : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>__aliwaitingroom_example</para>
            /// </summary>
            [NameInMap("CookieName")]
            [Validation(Required=false)]
            public string CookieName { get; set; }

            [NameInMap("CustomPageHtml")]
            [Validation(Required=false)]
            public string CustomPageHtml { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
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

            [NameInMap("HostNameAndPath")]
            [Validation(Required=false)]
            public List<ListWaitingRoomsResponseBodyWaitingRoomsHostNameAndPath> HostNameAndPath { get; set; }
            public class ListWaitingRoomsResponseBodyWaitingRoomsHostNameAndPath : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.</para>
                /// </summary>
                [NameInMap("Subdomain")]
                [Validation(Required=false)]
                public string Subdomain { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>200</para>
            /// </summary>
            [NameInMap("NewUsersPerMinute")]
            [Validation(Required=false)]
            public string NewUsersPerMinute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("QueueAllEnable")]
            [Validation(Required=false)]
            public string QueueAllEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>random</para>
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
            /// <para>3600</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public string SessionDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalActiveUsers")]
            [Validation(Required=false)]
            public string TotalActiveUsers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6a51d5bc6460887abd1291dc7d4d****</para>
            /// </summary>
            [NameInMap("WaitingRoomId")]
            [Validation(Required=false)]
            public string WaitingRoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("WaitingRoomType")]
            [Validation(Required=false)]
            public string WaitingRoomType { get; set; }

        }

    }

}
