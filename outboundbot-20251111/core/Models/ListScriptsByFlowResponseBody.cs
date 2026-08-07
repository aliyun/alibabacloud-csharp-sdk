// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptsByFlowResponseBody : TeaModel {
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
        public List<ListScriptsByFlowResponseBodyData> Data { get; set; }
        public class ListScriptsByFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>晓蜜机器人ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-MQuyjjb666</para>
            /// </summary>
            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>满意度调研</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>场景ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b54</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

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
        /// <para>Instance does not exist. Instance=ob-1234567890</para>
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
