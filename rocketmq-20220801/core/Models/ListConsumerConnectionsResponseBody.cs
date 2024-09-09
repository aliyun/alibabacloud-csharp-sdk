// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The returned error code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerConnectionsResponseBodyData Data { get; set; }
        public class ListConsumerConnectionsResponseBodyData : TeaModel {
            /// <summary>
            /// The client connection list
            /// </summary>
            [NameInMap("connections")]
            [Validation(Required=false)]
            public List<ListConsumerConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConsumerConnectionsResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// The ID of the client.
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// Host IP/Public IP
                /// </summary>
                [NameInMap("egressIp")]
                [Validation(Required=false)]
                public string EgressIp { get; set; }

                /// <summary>
                /// The `hostname` of the cloud-native box.
                /// </summary>
                [NameInMap("hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// The language of the client.
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// Consumption Mode
                /// - BROADCASTING
                /// - CLUSTERING
                /// </summary>
                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                /// <summary>
                /// The version of the client.
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The consumer group ID.
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the region in which the instance resides.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
