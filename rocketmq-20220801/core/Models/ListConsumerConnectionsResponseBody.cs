// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingPageNumber</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerConnectionsResponseBodyData Data { get; set; }
        public class ListConsumerConnectionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of client connections.</para>
            /// </summary>
            [NameInMap("connections")]
            [Validation(Required=false)]
            public List<ListConsumerConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConsumerConnectionsResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// <para>The client ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.17.135.197@17392#1936705963#551717232#9873695589062458</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The host IP address or Internet egress IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("egressIp")]
                [Validation(Required=false)]
                public string EgressIp { get; set; }

                /// <summary>
                /// <para>The client hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vos</para>
                /// </summary>
                [NameInMap("hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The client language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The consumption mode of the consumer:</para>
                /// <list type="bullet">
                /// <item><description><para>CLUSTERING</para>
                /// </description></item>
                /// <item><description><para>LITE_SELECTIVE</para>
                /// </description></item>
                /// <item><description><para>BROADCASTING</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BROADCASTING</para>
                /// </summary>
                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                /// <summary>
                /// <para>The client version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The consumer group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID-TEST</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance cannot be found.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3620115-6F1F-5CFB-AA3F-BBD4853B2EC4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
