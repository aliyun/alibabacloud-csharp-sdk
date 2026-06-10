// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetPublishTaskStateResponseBody : TeaModel {
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
        /// <para>The error message returned if the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>检查待发布模块是否空闲发生错误，faq</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>A map of error messages for each submodule, where the key is the submodule name and the value is the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;faq&quot;: [
        ///         &quot;答案资源未发布, 资源类型: 全局服务,名称: 动态答案服务&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Errors")]
        [Validation(Required=false)]
        public Dictionary<string, object> Errors { get; set; }

        /// <summary>
        /// <para>The publish task ID.</para>
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
        /// <para>The publish task ID. This field is redundant. Use the <c>Id</c> field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>FE_RUNNING</c>: Publishing</para>
        /// </description></item>
        /// <item><description><para><c>FE_SUCCESS</c>: Success</para>
        /// </description></item>
        /// <item><description><para><c>FE_FAILED</c>: Failed</para>
        /// </description></item>
        /// <item><description><para><c>FE_ABORTED</c>: Aborted</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FE_RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A map of warning messages for each submodule, where the key is the submodule name and the value is the warning message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;faq&quot;: [
        ///         &quot;答案资源未发布,类型:service名称:null,答案资源未发布,类型:service名称:null&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Warnings { get; set; }

    }

}
