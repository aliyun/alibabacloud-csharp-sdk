// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SearchAliDingGroupChatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The user group tree node information.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchAliDingGroupChatsResponseBodyItems> Items { get; set; }
        public class SearchAliDingGroupChatsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The conversation ID. This ID is typically used for JSSDK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cid-example</para>
            /// </summary>
            [NameInMap("chatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            /// <summary>
            /// <para>The conversation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: one-on-one chat.</description></item>
            /// <item><description><b>1</b>: group chat.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For a one-on-one chat, you do not need to specify <b>openConversationId</b>. Specify the employee ID in <b>receiverUserIdList</b>. For a one-on-one chat between two users, specify the employee ID of either user. For a one-on-one chat between a user and a bot, specify the employee ID of the user.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNAL_GROUP</para>
            /// </summary>
            [NameInMap("conversationType")]
            [Validation(Required=false)]
            public string ConversationType { get; set; }

            /// <summary>
            /// <para>Indicates whether the current user has enabled the Do Not Disturb mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("muted")]
            [Validation(Required=false)]
            public bool? Muted { get; set; }

            /// <summary>
            /// <para>The title of the scheduled meeting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer project group</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The starting cursor for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
