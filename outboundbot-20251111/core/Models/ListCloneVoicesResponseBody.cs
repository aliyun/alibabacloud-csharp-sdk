// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListCloneVoicesResponseBody : TeaModel {
        /// <summary>
        /// <para>返回码</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCloneVoicesResponseBodyData Data { get; set; }
        public class ListCloneVoicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>数据列表</para>
            /// </summary>
            [NameInMap("CloneVoices")]
            [Validation(Required=false)]
            public List<ListCloneVoicesResponseBodyDataCloneVoices> CloneVoices { get; set; }
            public class ListCloneVoicesResponseBodyDataCloneVoices : TeaModel {
                /// <summary>
                /// <para>克隆音色ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b15</para>
                /// </summary>
                [NameInMap("CloneVoiceId")]
                [Validation(Required=false)]
                public string CloneVoiceId { get; set; }

                /// <summary>
                /// <para>创建时间，毫秒级时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>实例ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>模型名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>CosyVoice</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试克隆音</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>目前支持IFLYTEK、VOLC</para>
                /// 
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                /// <summary>
                /// <para>状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>租户ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1308144684576765</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>更新时间，毫秒级时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// <para>音色</para>
                /// 
                /// <b>Example:</b>
                /// <para>cosyvoice-v3-flash-voicebot2-8aa485413eba42089c873eec1f901d64</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

            }

            /// <summary>
            /// <para>页码，从1开始</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>每页记录数</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>符合条件的记录总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>错误信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance does not exist. Instance=anchashi.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>错误信息中的变量值列表</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FDAC7-13C5-1B64-A853-999DF105B9EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>是否调用成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
