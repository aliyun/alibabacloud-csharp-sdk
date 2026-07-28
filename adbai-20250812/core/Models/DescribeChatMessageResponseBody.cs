// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class DescribeChatMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-18T02:01:56Z</para>
        /// </summary>
        [NameInMap("CompletedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>The task content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeChatMessageResponseBodyContent> Content { get; set; }
        public class DescribeChatMessageResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The result set.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeChatMessageResponseBodyContentData Data { get; set; }
            public class DescribeChatMessageResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>The ID of the data API operation that is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>call_e0e9ee423c7e4ba88d058fd6</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>The name of the data API operation that is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>describeScalingRecommendation</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The output of the data API operation that is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;: &quot;text&quot;, &quot;text&quot;: &quot;Skill not found: instance_health_inspection&quot;}]</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the content is incremental.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Delta")]
            [Validation(Required=false)]
            public bool? Delta { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to get sse streaming, please try again later.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg_294c8b98-dc64-4c82-9417-e03522a631f6</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <para>The message object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>The sequence number of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SequenceNumber")]
            [Validation(Required=false)]
            public long? SequenceNumber { get; set; }

            /// <summary>
            /// <para>The message status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The text content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3 MB\n-</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-18T02:01:56Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeChatMessageResponseBodyData Data { get; set; }
        public class DescribeChatMessageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The parameters of the data API operation that is called.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;instanceName&quot;: &quot;amv-bp1b9y9xhvpzm9p0&quot;, &quot;pageNumber&quot;: 1, &quot;pageSize&quot;: 10}</para>
            /// </summary>
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// <para>The ID of the data API operation that is called.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_1891f1689bc44ab292aadff3</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The name of the data API operation that is called.</para>
            /// 
            /// <b>Example:</b>
            /// <para>describeScalingRecommendation</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output of the data API operation that is called.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;: &quot;text&quot;, &quot;text&quot;: &quot;Skill not found: instance_health_inspection&quot;}]</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the content is incremental.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Delta")]
        [Validation(Required=false)]
        public bool? Delta { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to get sse streaming, please try again later.</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97616</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_294c8b98-dc64-4c82-9417-e03522a631f6</para>
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        /// <summary>
        /// <para>The message object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>content</para>
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>The content output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;: &quot;text&quot;, &quot;text&quot;: &quot;Skill not found: instance_health_inspection&quot;}]</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B47EED99-BFA5-529D-8D85-A6642421D390</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The message role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The sequence number of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SequenceNumber")]
        [Validation(Required=false)]
        public long? SequenceNumber { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593b51eef93b443fb2ba2a6dc68b737b</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The message status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The text content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>：-636 KB</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The message type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
