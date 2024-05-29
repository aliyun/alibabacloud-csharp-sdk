// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayAuthConsumerDetailResponseBody : TeaModel {
        /// <summary>
        /// The status code. A value of 200 is returned if the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayAuthConsumerDetailResponseBodyData Data { get; set; }
        public class GetGatewayAuthConsumerDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The status of the consumer. Valid values:
            /// 
            /// *   true: enabled
            /// *   false: disabled
            /// </summary>
            [NameInMap("ConsumerStatus")]
            [Validation(Required=false)]
            public bool? ConsumerStatus { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The encryption type. Valid values:
            /// 
            /// *   RSA
            /// *   OCT
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// The unique ID of the gateway.
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// The time when the consumer authentication record was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the consumer authentication record was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the consumer.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The JWT public key. The JSON format is supported.
            /// </summary>
            [NameInMap("Jwks")]
            [Validation(Required=false)]
            public string Jwks { get; set; }

            /// <summary>
            /// The name of the key used for JWT-based identity authentication.
            /// </summary>
            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            /// <summary>
            /// The value of the key used for JWT-based identity authentication.
            /// </summary>
            [NameInMap("KeyValue")]
            [Validation(Required=false)]
            public string KeyValue { get; set; }

            /// <summary>
            /// The name of the consumer.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The creator.
            /// </summary>
            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            /// <summary>
            /// The resource list.
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetGatewayAuthConsumerDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetGatewayAuthConsumerDetailResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// The consumer ID.
                /// </summary>
                [NameInMap("ConsumerId")]
                [Validation(Required=false)]
                public long? ConsumerId { get; set; }

                /// <summary>
                /// The unique ID of the gateway.
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// The time when the resource associated with the consumer authentication record was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the resource associated with the consumer authentication record was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the authorized resource for the consumer.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The resource authorization state. Valid values:
                /// 
                /// *   true: Resource authorization is enabled.
                /// *   false: Resource authorization is disabled.
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public bool? ResourceStatus { get; set; }

                /// <summary>
                /// The ID of the route.
                /// </summary>
                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                /// <summary>
                /// The name of the route.
                /// </summary>
                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

            }

            /// <summary>
            /// The names of the parameters that are required to verify each token. By default, each token is prefixed with Bearer and stored in the Authorization header, such as `Authorization: Bearer <Content of a token>`.
            /// </summary>
            [NameInMap("TokenName")]
            [Validation(Required=false)]
            public string TokenName { get; set; }

            /// <summary>
            /// Specifies whether to enable pass-through.
            /// </summary>
            [NameInMap("TokenPass")]
            [Validation(Required=false)]
            public bool? TokenPass { get; set; }

            /// <summary>
            /// The positions of the parameters that are required to verify each token. By default, each token is prefixed with Bearer and stored in the Authorization header, such as `Authorization: Bearer <Content of a token>`.
            /// </summary>
            [NameInMap("TokenPosition")]
            [Validation(Required=false)]
            public string TokenPosition { get; set; }

            /// <summary>
            /// The prefixes of the parameters that are required to verify each token. By default, each token is prefixed with Bearer and stored in the Authorization header, such as `Authorization: Bearer <Content of a token>`.
            /// </summary>
            [NameInMap("TokenPrefix")]
            [Validation(Required=false)]
            public string TokenPrefix { get; set; }

            /// <summary>
            /// The authentication type. Valid values:
            /// 
            /// *   JWT
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the \\*\\*%s\\*\\* variable in the **ErrMessage** parameter.
        /// 
        /// >  If the return value of the **ErrMessage** parameter is **The Value of Input Parameter %s is not valid** and the return value of the **DynamicMessage** parameter is **DtsJobId**, the specified **DtsJobId** parameter is invalid.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
