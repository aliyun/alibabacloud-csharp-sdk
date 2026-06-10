// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CancelPublishTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of business types.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <para>The time when the task was created, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-12T06:30:17Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The error message returned if the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>检查待发布模块是否空闲发生错误，faq</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The ID of the publish task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The time when the task was last modified, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-12T06:30:33Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CBF0581-EAE7-1DC4-95C6-A089656A1E2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the publish task. This is a redundant field. We recommend that you use the <c>Id</c> field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <para><c>FE_RUNNING</c>: in progress, <c>FE_SUCCESS</c>: succeeded, <c>FE_FAILED</c>: failed, <c>FE_ABORTED</c>: aborted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE_ABORTED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
