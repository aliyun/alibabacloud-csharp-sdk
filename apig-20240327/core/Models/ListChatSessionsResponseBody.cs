// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListChatSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListChatSessionsResponseBodyData Data { get; set; }
        public class ListChatSessionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of chat sessions. Each element in the list is named session and represents a chat session.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListChatSessionsResponseBodyDataContent> Content { get; set; }
            public class ListChatSessionsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The name of the chat session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product consultation session</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of API products associated with the session. Each element in the list is named product.</para>
                /// </summary>
                [NameInMap("products")]
                [Validation(Required=false)]
                public List<string> Products { get; set; }

                /// <summary>
                /// <para>The ID of the chat session. You can use this ID to locate the session in API operations such as UpdateChatSession, DeleteChatSession, and ListConversations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ses-xxxxxxxx</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The conversation type of the session. Valid values: MODEL and AGENT. These values are defined in the talkType enumeration of the CreateChatSession request parameter, and this response parameter does not have the @enums annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MODEL</para>
                /// </summary>
                [NameInMap("talkType")]
                [Validation(Required=false)]
                public string TalkType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that the last page has been reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-xxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
