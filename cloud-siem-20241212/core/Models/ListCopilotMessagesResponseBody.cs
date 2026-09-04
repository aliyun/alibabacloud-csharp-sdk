// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListCopilotMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The API version.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupProductions~~">DescribeGroupProductions</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1.2</para>
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The list of conversation messages.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListCopilotMessagesResponseBodyItems> Items { get; set; }
        public class ListCopilotMessagesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The client message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>366932fb-9a83-4a2d-94dd-c925b35f****</para>
            /// </summary>
            [NameInMap("ClientMessageId")]
            [Validation(Required=false)]
            public string ClientMessageId { get; set; }

            /// <summary>
            /// <para>The sent content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The correlation analysis of alerts and network logs has been completed</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-11T02:01:36Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AB917534-C484-5BA0-9077-0D5D1D2F****</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The message sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MessageSequence")]
            [Validation(Required=false)]
            public long? MessageSequence { get; set; }

            /// <summary>
            /// <para>The message role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc18b894-19a3-45ee-8768-a59478e0****</para>
            /// </summary>
            [NameInMap("TurnId")]
            [Validation(Required=false)]
            public string TurnId { get; set; }

        }

        /// <summary>
        /// <para>The maximum amount of data read in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
