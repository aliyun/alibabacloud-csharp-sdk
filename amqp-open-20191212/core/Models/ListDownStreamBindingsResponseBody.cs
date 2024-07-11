// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListDownStreamBindingsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDownStreamBindingsResponseBodyData Data { get; set; }
        public class ListDownStreamBindingsResponseBodyData : TeaModel {
            /// <summary>
            /// The bindings.
            /// </summary>
            [NameInMap("Bindings")]
            [Validation(Required=false)]
            public List<ListDownStreamBindingsResponseBodyDataBindings> Bindings { get; set; }
            public class ListDownStreamBindingsResponseBodyDataBindings : TeaModel {
                /// <summary>
                /// The x-match attribute. Valid values:
                /// 
                /// *   **all:** A headers exchange routes a message to a queue only if all binding attributes of the queue except for x-match match the headers attributes of the message. This value is the default value.
                /// *   **any:** A headers exchange routes a message to a queue if one or more binding attributes of the queue except for x-match match the headers attributes of the message.
                /// 
                /// This parameter is available only for headers exchanges.
                /// </summary>
                [NameInMap("Argument")]
                [Validation(Required=false)]
                public string Argument { get; set; }

                /// <summary>
                /// The binding key.
                /// 
                /// *   If the source exchange is not a topic exchange, the binding key must meet the following conventions:
                /// 
                ///     *   The binding key can contain only letters, digits, hyphens (-), underscores (_), periods (.), forward slashes (/), and at signs (@).
                ///     *   The binding key must be 1 to 255 characters in length.
                /// 
                /// *   If the source exchange is a topic exchange, the binding key must meet the following conventions:
                /// 
                ///     *   The binding key can contain letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).
                ///     *   The binding key cannot start or end with a period (.). If a binding key starts with a number sign (#) or an asterisk (\\*), the number sign (#) or asterisk (\\*) must be followed by a period (.). If the binding key ends with a number sign (#) or an asterisk (\\*), the number sign (#) or asterisk (\\*) must be preceded by a period (.). If a number sign (#) or an asterisk (\\*) is used in the middle of a binding key, the number sign (#) or asterisk (\\*) must be preceded and followed by a period (.).
                ///     *   The binding key must be 1 to 255 characters in length.
                /// </summary>
                [NameInMap("BindingKey")]
                [Validation(Required=false)]
                public string BindingKey { get; set; }

                /// <summary>
                /// The type of the object to which the source exchange is bound. Valid values:
                /// 
                /// *   **QUEUE**
                /// *   **EXCHANGE**
                /// </summary>
                [NameInMap("BindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// The name of the object to which the source exchange is bound.
                /// </summary>
                [NameInMap("DestinationName")]
                [Validation(Required=false)]
                public string DestinationName { get; set; }

                /// <summary>
                /// The name of the source exchange.
                /// </summary>
                [NameInMap("SourceExchange")]
                [Validation(Required=false)]
                public string SourceExchange { get; set; }

            }

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
