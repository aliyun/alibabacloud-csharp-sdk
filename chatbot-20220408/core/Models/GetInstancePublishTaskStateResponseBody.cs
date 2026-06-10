// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetInstancePublishTaskStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of business types.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <para>The UTC time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-12T06:30:17Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The error message if the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>检查待发布模块是否空闲发生错误，faq</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>A map of error messages for each submodule, where the key is the submodule and the value is an array of errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;robot_ds&quot;: [
        ///         &quot;{\&quot;dialogName\&quot;:\&quot;TEST\&quot;,\&quot;errorMessage\&quot;:[\&quot;<a href="mailto:medusa@invocation.error.service.offline">medusa@invocation.error.service.offline</a>@请发布对话流所引用服务后重试！\&quot;],\&quot;needRefresh\&quot;:false,\&quot;success\&quot;:false}&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Errors")]
        [Validation(Required=false)]
        public Dictionary<string, object> Errors { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The UTC time when the task was last modified.</para>
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
        /// <para>The task ID, returned as a string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        /// <summary>
        /// <para>The status of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE_RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A map of warning messages for each submodule, where the key is the submodule and the value is an array of warnings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;category_bind_faq&quot;: [
        ///         &quot;以下类目没有发布到正式环境：项目交付类目&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Warnings { get; set; }

    }

}
