// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkDescribeRecordFileUrlResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClinkDescribeRecordFileUrlResponseBodyData Data { get; set; }
        public class ClinkDescribeRecordFileUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>录音流程列表。仅当获取 mp3 格式通话录音时返回（不传 recordSide 且 recordType 为 &quot;record&quot; 或未传）。</para>
            /// </summary>
            [NameInMap("AudioFlows")]
            [Validation(Required=false)]
            public List<ClinkDescribeRecordFileUrlResponseBodyDataAudioFlows> AudioFlows { get; set; }
            public class ClinkDescribeRecordFileUrlResponseBodyDataAudioFlows : TeaModel {
                /// <summary>
                /// <para>节点，1：录音，2：保持，3：静音，4：咨询</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Node")]
                [Validation(Required=false)]
                public long? Node { get; set; }

                /// <summary>
                /// <para>时间戳，单位：秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>类型，0：开始，1：结束</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>通话录音地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("RecordFileUrl")]
            [Validation(Required=false)]
            public string RecordFileUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
