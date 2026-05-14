// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkCdrObDetailsResponseBody : TeaModel {
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
        public ClinkCdrObDetailsResponseBodyData Data { get; set; }
        public class ClinkCdrObDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[外呼详情] #外呼详情</para>
            /// </summary>
            [NameInMap("CdrObDetails")]
            [Validation(Required=false)]
            public List<ClinkCdrObDetailsResponseBodyDataCdrObDetails> CdrObDetails { get; set; }
            public class ClinkCdrObDetailsResponseBodyDataCdrObDetails : TeaModel {
                /// <summary>
                /// <para>客户接听时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717583928</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public long? AnswerTime { get; set; }

                /// <summary>
                /// <para>通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>CallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1d7acd5d-xxxx-xxxx-xxxx-0d3c08317140</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>通话类型，说明参考 通用字段 #通用字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public long? CallType { get; set; }

                /// <summary>
                /// <para>通话类型描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CallTypeDesc")]
                [Validation(Required=false)]
                public string CallTypeDesc { get; set; }

                /// <summary>
                /// <para>客户响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717583922</para>
                /// </summary>
                [NameInMap("CalleeRingingTime")]
                [Validation(Required=false)]
                public long? CalleeRingingTime { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// <para>座席电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ClientNumber")]
                [Validation(Required=false)]
                public string ClientNumber { get; set; }

                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>呼叫类型，说明参考 通用字段 #通用字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>208</para>
                /// </summary>
                [NameInMap("DetailCallType")]
                [Validation(Required=false)]
                public long? DetailCallType { get; set; }

                /// <summary>
                /// <para>呼叫类型描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("DetailCallTypeDesc")]
                [Validation(Required=false)]
                public string DetailCallTypeDesc { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717583950</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>通话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>medias_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("MainUniqueId")]
                [Validation(Required=false)]
                public string MainUniqueId { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ObSipCause")]
                [Validation(Required=false)]
                public string ObSipCause { get; set; }

                /// <summary>
                /// <para>被叫状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ObSipCauseRaw")]
                [Validation(Required=false)]
                public string ObSipCauseRaw { get; set; }

                /// <summary>
                /// <para>录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>呼叫情况</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SipCause")]
                [Validation(Required=false)]
                public long? SipCause { get; set; }

                /// <summary>
                /// <para>呼叫情况描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("SipCauseDesc")]
                [Validation(Required=false)]
                public string SipCauseDesc { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717583916</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>客户彩铃录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TsiFile")]
                [Validation(Required=false)]
                public string TsiFile { get; set; }

                /// <summary>
                /// <para>通话唯一ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <para>WebRTCCallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("WebrtcCallId")]
                [Validation(Required=false)]
                public string WebrtcCallId { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
