// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptsResponseBody : TeaModel {
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
        public ListScriptsResponseBodyData Data { get; set; }
        public class ListScriptsResponseBodyData : TeaModel {
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
            /// <para>数据列表</para>
            /// </summary>
            [NameInMap("Scripts")]
            [Validation(Required=false)]
            public List<ListScriptsResponseBodyDataScripts> Scripts { get; set; }
            public class ListScriptsResponseBodyDataScripts : TeaModel {
                /// <summary>
                /// <para>并发数</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public int? Concurrency { get; set; }

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
                /// <para>询问用户对本次服务是否满意</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>草稿版本ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b60</para>
                /// </summary>
                [NameInMap("DraftVersionId")]
                [Validation(Required=false)]
                public string DraftVersionId { get; set; }

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
                /// <para>NLU接入类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANAGED</para>
                /// </summary>
                [NameInMap("NluAccessType")]
                [Validation(Required=false)]
                public string NluAccessType { get; set; }

                /// <summary>
                /// <para>NLU引擎类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>BEEBOT</para>
                /// </summary>
                [NameInMap("NluEngine")]
                [Validation(Required=false)]
                public string NluEngine { get; set; }

                /// <summary>
                /// <para>电话号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>01057316547</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>已发布版本ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b41</para>
                /// </summary>
                [NameInMap("PublishedVersionId")]
                [Validation(Required=false)]
                public string PublishedVersionId { get; set; }

                /// <summary>
                /// <para>场景ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>更新时间，毫秒级时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

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
        /// <para>Instance does not exist. Instance=ob-0987654321</para>
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
