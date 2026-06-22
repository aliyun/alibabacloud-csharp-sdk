// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>OK</c>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChatGroupResponseBodyData Data { get; set; }
        public class ListChatGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The group list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListChatGroupResponseBodyDataList> List { get; set; }
            public class ListChatGroupResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The business number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8613800**</para>
                /// </summary>
                [NameInMap("BusinessNumber")]
                [Validation(Required=false)]
                public string BusinessNumber { get; set; }

                /// <summary>
                /// <para>The role of the bot in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("BusinessRole")]
                [Validation(Required=false)]
                public string BusinessRole { get; set; }

                /// <summary>
                /// <para>The group description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time the group was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>94</para>
                /// </summary>
                [NameInMap("GmtModifier")]
                [Validation(Required=false)]
                public long? GmtModifier { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EA30d***</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The group link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("GroupLink")]
                [Validation(Required=false)]
                public string GroupLink { get; set; }

                /// <summary>
                /// <para>The group status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("GroupStatus")]
                [Validation(Required=false)]
                public string GroupStatus { get; set; }

                /// <summary>
                /// <para>The group type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>The group invitation link.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://chat.whatsapp.com/">https://chat.whatsapp.com/</a>***</para>
                /// </summary>
                [NameInMap("InviteLink")]
                [Validation(Required=false)]
                public string InviteLink { get; set; }

                /// <summary>
                /// <para>The group\&quot;s profile picture.</para>
                /// </summary>
                [NameInMap("ProfilePictureFile")]
                [Validation(Required=false)]
                public string ProfilePictureFile { get; set; }

                /// <summary>
                /// <para>The group subject.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a test subject</para>
                /// </summary>
                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                /// <summary>
                /// <para>The total number of group participants.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35</para>
                /// </summary>
                [NameInMap("TotalParticipantCount")]
                [Validation(Required=false)]
                public long? TotalParticipantCount { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
