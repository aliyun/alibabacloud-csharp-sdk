// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitVideoAuditResponseBody : TeaModel {
        /// <summary>
        /// <para>业务处理结果状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>视频审校任务提交后的返回数据</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitVideoAuditResponseBodyData Data { get; set; }
        public class SubmitVideoAuditResponseBodyData : TeaModel {
            /// <summary>
            /// <para>视频审校任务的唯一标识，可用于后续查询任务状态和结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>HTTP响应状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>业务处理结果描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务提交成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>本次API请求的唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求是否处理成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
