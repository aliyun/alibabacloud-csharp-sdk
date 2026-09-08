// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListGroupChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupChatMessagesResponseBodyData Data { get; set; }
        public class ListGroupChatMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Message list.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListGroupChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListGroupChatMessagesResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>Message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;variables&quot;:{},&quot;text&quot;:&quot;<para>好的，不客气</para>&quot;,&quot;contentType&quot;:&quot;Text&quot;,&quot;subContentType&quot;:&quot;richtext&quot;}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Indicates whether the message was revoked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Recalled")]
                [Validation(Required=false)]
                public bool? Recalled { get; set; }

                /// <summary>
                /// <para>Sender profile picture URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx.com">http://xxxxx.com</a></para>
                /// </summary>
                [NameInMap("SenderAvatarUrl")]
                [Validation(Required=false)]
                public string SenderAvatarUrl { get; set; }

                /// <summary>
                /// <para>User ID of the message sender.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64bb4ececc34fc5ec1ca1153</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                /// <summary>
                /// <para>Sender name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-agent@test-instanceId</para>
                /// </summary>
                [NameInMap("SenderName")]
                [Validation(Required=false)]
                public string SenderName { get; set; }

                /// <summary>
                /// <para>Sender type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ADMIN</b>: system</para>
                /// </description></item>
                /// <item><description><para><b>CUSTOMER</b>: visitor</para>
                /// </description></item>
                /// <item><description><para><b>AGENT</b>: agent</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMER</para>
                /// </summary>
                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

                /// <summary>
                /// <para>Message timestamp, in Unix timestamp format, measured in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1696126980371</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <para>Token for the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54d1a616d95a4a01ba58967a9115b649</para>
            /// </summary>
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code returned in the response. A value of 200 indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2263B273-AC1B-44EB-BA98-87F2322C6780</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
