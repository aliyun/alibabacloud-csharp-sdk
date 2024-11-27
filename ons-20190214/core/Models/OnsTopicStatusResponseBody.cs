// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The data structure of the queried topic.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicStatusResponseBodyData Data { get; set; }
        public class OnsTopicStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The point in time when the latest message is ready in the topic. If no message exists in the topic, the return value of this parameter is 0.</para>
            /// <para>The value of this parameter is a UNIX timestamp in milliseconds.</para>
            /// <para>For information about the definition of ready messages and ready time, see <a href="https://help.aliyun.com/document_detail/29533.html">Terms</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570864984364</para>
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// <para>Indicates the operations that you can perform on the topic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: You can publish messages to the topic.</description></item>
            /// <item><description><b>4</b>: You can subscribe to the topic.</description></item>
            /// <item><description><b>6</b>: You can publish messages to and subscribe to the topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Perm")]
            [Validation(Required=false)]
            public int? Perm { get; set; }

            /// <summary>
            /// <para>The total number of messages in all partitions of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2310</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>427EE49D-D762-41FB-8F3D-9BAC96C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
