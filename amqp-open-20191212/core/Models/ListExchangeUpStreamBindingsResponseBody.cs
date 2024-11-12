// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangeUpStreamBindingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangeUpStreamBindingsResponseBodyData Data { get; set; }
        public class ListExchangeUpStreamBindingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bindings.</para>
            /// </summary>
            [NameInMap("Bindings")]
            [Validation(Required=false)]
            public List<ListExchangeUpStreamBindingsResponseBodyDataBindings> Bindings { get; set; }
            public class ListExchangeUpStreamBindingsResponseBodyDataBindings : TeaModel {
                /// <summary>
                /// <para>The x-match attribute. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>all:</b> A headers exchange routes a message to a queue only if all binding attributes of the queue except for x-match match the headers attributes of the message. This value is the default value.</description></item>
                /// <item><description><b>any:</b> A headers exchange routes a message to a queue if one or more binding attributes of the queue except for x-match match the headers attributes of the message.</description></item>
                /// </list>
                /// <para>This parameter is available only for headers exchanges.</para>
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
                /// <item><description><para>If the source exchange is not a topic exchange, the binding key must meet the following conventions:</para>
                /// <list type="bullet">
                /// <item><description>The binding key can contain only letters, digits, hyphens (-), underscores (_), periods (.), forward slashes (/), and at signs (@).</description></item>
                /// <item><description>The binding key must be 1 to 255 characters in length.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If the source exchange is a topic exchange, the binding key must meet the following conventions:</para>
                /// <list type="bullet">
                /// <item><description>The binding key can contain letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</description></item>
                /// <item><description>The binding key cannot start or end with a period (.). If a binding key starts with a number sign (#) or an asterisk (\<em>), the number sign (#) or asterisk (\</em>) must be followed by a period (.). If the binding key ends with a number sign (#) or an asterisk (\<em>), the number sign (#) or asterisk (\</em>) must be preceded by a period (.). If a number sign (#) or an asterisk (\<em>) is used in the middle of a binding key, the number sign (#) or asterisk (\</em>) must be preceded and followed by a period (.).</description></item>
                /// <item><description>The binding key must be 1 to 255 characters in length.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>amq.dle.test</para>
                /// </summary>
                [NameInMap("BindingKey")]
                [Validation(Required=false)]
                public string BindingKey { get; set; }

                /// <summary>
                /// <para>The type of the object to which the source exchange is bound. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>QUEUE</b></description></item>
                /// <item><description><b>EXCHANGE</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EXCHANGE</para>
                /// </summary>
                [NameInMap("BindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The name of the object to which the source exchange is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DestinationName")]
                [Validation(Required=false)]
                public string DestinationName { get; set; }

                /// <summary>
                /// <para>The name of the source exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dle</para>
                /// </summary>
                [NameInMap("SourceExchange")]
                [Validation(Required=false)]
                public string SourceExchange { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>caebacccb2be03f84eb48b699f0a****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DCCCE88-BC82-4A4F-AF5E-9A759672B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
