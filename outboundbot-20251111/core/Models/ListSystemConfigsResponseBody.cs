// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListSystemConfigsResponseBody : TeaModel {
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
        public List<ListSystemConfigsResponseBodyData> Data { get; set; }
        public class ListSystemConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>创建时间，毫秒级时间戳</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786085104904</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>callableTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>对象ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>外呼开发时补充参数限制</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>更新时间，毫秒级时间戳</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786085104904</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// <para>值</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

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
        /// <para>Instance does not exist. Instance=outb001</para>
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
