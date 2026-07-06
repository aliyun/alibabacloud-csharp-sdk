// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class QueryMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The query message results.</para>
        /// </summary>
        [NameInMap("MessageList")]
        [Validation(Required=false)]
        public List<QueryMessageResponseBodyMessageList> MessageList { get; set; }
        public class QueryMessageResponseBodyMessageList : TeaModel {
            /// <summary>
            /// <para>The chaincode checksum.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public long? Checksum { get; set; }

            /// <summary>
            /// <para>The message key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Indicates whether the key is truncated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("KeyTruncated")]
            [Validation(Required=false)]
            public bool? KeyTruncated { get; set; }

            /// <summary>
            /// <para>The partition offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public long? Offset { get; set; }

            /// <summary>
            /// <para>The partition ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public long? Partition { get; set; }

            /// <summary>
            /// <para>The size of the serialized key. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("SerializedKeySize")]
            [Validation(Required=false)]
            public int? SerializedKeySize { get; set; }

            /// <summary>
            /// <para>The size of the serialized value. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SerializedValueSize")]
            [Validation(Required=false)]
            public int? SerializedValueSize { get; set; }

            /// <summary>
            /// <para>The message creation time. Represented as a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1705482172640</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The timestamp type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateTime</para>
            /// </summary>
            [NameInMap("TimestampType")]
            [Validation(Required=false)]
            public string TimestampType { get; set; }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dqc_test2</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The size of the truncated key message. Value: bytes.</para>
            /// <remarks>
            /// <para>Each queried message displays up to 1 KB of content; content exceeding this limit will be automatically truncated. <a href="https://help.aliyun.com/document_detail/113172.html">Learn more</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TruncatedKeySize")]
            [Validation(Required=false)]
            public int? TruncatedKeySize { get; set; }

            /// <summary>
            /// <para>The size of the truncated value message. Unit: bytes.</para>
            /// <remarks>
            /// <para>Each queried message displays up to 1 KB of content; content exceeding this limit will be automatically truncated. <a href="https://help.aliyun.com/document_detail/113172.html">Learn more</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TruncatedValueSize")]
            [Validation(Required=false)]
            public int? TruncatedValueSize { get; set; }

            /// <summary>
            /// <para>The message value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome to Ali kafka</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>Indicates whether the value is truncated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ValueTruncated")]
            [Validation(Required=false)]
            public bool? ValueTruncated { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABA4A7FD-E10F-45C7-9774-A5236015****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
