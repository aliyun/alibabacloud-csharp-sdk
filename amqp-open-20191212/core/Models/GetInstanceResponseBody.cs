// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenewInstance")]
            [Validation(Required=false)]
            public bool? AutoRenewInstance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>amqp-cn-st21x7kv****.not-support</para>
            /// </summary>
            [NameInMap("ClassicEndpoint")]
            [Validation(Required=false)]
            public string ClassicEndpoint { get; set; }

            [NameInMap("EncryptedInstance")]
            [Validation(Required=false)]
            public bool? EncryptedInstance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1651507200000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>amqp-cn-*********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yunQi-instance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxEipTps")]
            [Validation(Required=false)]
            public int? MaxEipTps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxQueue")]
            [Validation(Required=false)]
            public int? MaxQueue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxTps")]
            [Validation(Required=false)]
            public int? MaxTps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("MaxVhost")]
            [Validation(Required=false)]
            public int? MaxVhost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1651507200000</para>
            /// </summary>
            [NameInMap("OrderCreateTime")]
            [Validation(Required=false)]
            public long? OrderCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRE_PAID</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>amqp-cn-st21x7kv****.mq-amqp.cn-hangzhou-a.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PrivateEndpoint")]
            [Validation(Required=false)]
            public string PrivateEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx.cn-hangzhou.xxx.net.mq.amqp.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PublicEndpoint")]
            [Validation(Required=false)]
            public string PublicEndpoint { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SERVING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEIP")]
            [Validation(Required=false)]
            public bool? SupportEIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SupportTracing")]
            [Validation(Required=false)]
            public bool? SupportTracing { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetInstanceResponseBodyDataTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TracingStorageTime")]
            [Validation(Required=false)]
            public int? TracingStorageTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92385FD2-624A-48C9-8FB5-753F2AFA***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
