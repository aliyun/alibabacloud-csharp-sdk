// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptProfileTemplatesResponseBody : TeaModel {
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
        public List<ListScriptProfileTemplatesResponseBodyData> Data { get; set; }
        public class ListScriptProfileTemplatesResponseBodyData : TeaModel {
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
            /// <para>描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>作为调研专员，对服务总体满意度、服务亮点、改进建议、服务效率、员工态度、再次选择意愿进行依次询问，并采集信息。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>标签定义</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;总体满意度\&quot;,\&quot;description\&quot;:\&quot;收集对服务的整体满意度的评价信息\&quot;,\&quot;candidateValues\&quot;:[\&quot;非常满意\&quot;,\&quot;满意\&quot;,\&quot;一般\&quot;,\&quot;不满意\&quot;,\&quot;非常不满意\&quot;]},{\&quot;name\&quot;:\&quot;服务亮点\&quot;,\&quot;description\&quot;:\&quot;客户对于服务亮点或者满意的地方的描述\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;改进建议\&quot;,\&quot;description\&quot;:\&quot;客户对于改进意见的描述\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;服务效率\&quot;,\&quot;description\&quot;:\&quot;客户对于服务响应速度和服务完成的时效性的反馈\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;员工态度\&quot;,\&quot;description\&quot;:\&quot;客户对于对于服务人员的专业度和态度的评价\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;再次选择意愿\&quot;,\&quot;description\&quot;:\&quot;客户是否愿意再次选择\&quot;,\&quot;candidateValues\&quot;:[\&quot;是\&quot;,\&quot;否\&quot;]}]</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务满意度调研</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>schema定义</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;name\&quot;:\&quot;李明\&quot;,\&quot;gender\&quot;:\&quot;男\&quot;}</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>模板ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

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
            /// <para>变量定义</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;name\&quot;,\&quot;description\&quot;:\&quot;客户姓名\&quot;},{\&quot;name\&quot;:\&quot;gender\&quot;,\&quot;description\&quot;:\&quot;客户性别\&quot;}]</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public string Variables { get; set; }

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
        /// <para>Instance does not exist. Instance=ob-9876543210.</para>
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
