// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueUpStreamBindingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueueUpStreamBindingsResponseBodyData Data { get; set; }
        public class ListQueueUpStreamBindingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bindings.</para>
            /// </summary>
            [NameInMap("Bindings")]
            [Validation(Required=false)]
            public List<ListQueueUpStreamBindingsResponseBodyDataBindings> Bindings { get; set; }
            public class ListQueueUpStreamBindingsResponseBodyDataBindings : TeaModel {
                /// <summary>
                /// <para>The x-match property. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>all</b>: This is the default value. All key-value pairs in the message header must match.</para>
                /// </description></item>
                /// <item><description><para><b>any</b>: At least one key-value pair in the message header must match.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is valid only for headers exchanges. It is invalid for other types of exchanges.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Argument")]
                [Validation(Required=false)]
                public string Argument { get; set; }

                /// <summary>
                /// <para>The binding key.</para>
                /// <list type="bullet">
                /// <item><description><para>If the source exchange is not a topic exchange:</para>
                /// <list type="bullet">
                /// <item><description><para>The binding key can contain only letters, digits, hyphens (-), underscores (_), periods (.), forward slashes (/), and at signs (@).</para>
                /// </description></item>
                /// <item><description><para>The binding key must be 1 to 255 characters in length.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If the source exchange is a topic exchange:</para>
                /// <list type="bullet">
                /// <item><description><para>The binding key can contain letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</para>
                /// </description></item>
                /// <item><description><para>The binding key cannot start or end with a period (.). If a number sign (#) or an asterisk (\*) is at the beginning of the key, it must be followed by a period (.). If it is at the end of the key, it must be preceded by a period (.). If it is in the middle of the key, it must be enclosed by periods (.).</para>
                /// </description></item>
                /// <item><description><para>The binding key must be 1 to 255 characters in length.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>amq.test</para>
                /// </summary>
                [NameInMap("BindingKey")]
                [Validation(Required=false)]
                public string BindingKey { get; set; }

                /// <summary>
                /// <para>The type of the destination object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>QUEUE</b></para>
                /// </description></item>
                /// <item><description><para><b>EXCHANGE</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>QUEUE</para>
                /// </summary>
                [NameInMap("BindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The name of the destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QueueTest</para>
                /// </summary>
                [NameInMap("DestinationName")]
                [Validation(Required=false)]
                public string DestinationName { get; set; }

                /// <summary>
                /// <para>The name of the source exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SourceExchange")]
                [Validation(Required=false)]
                public string SourceExchange { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of results returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public string MaxResults { get; set; }

            /// <summary>
            /// <para>The token that marks the end of the current results. An empty value indicates that all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>caebacccb2be03f84eb48b699f0a****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BFB1C9D-08A2-4859-A47C-403C9EFA2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
