// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AttachTaskRequest : TeaModel {
        /// <summary>
        /// <para>The calling string (callee information and parameter list). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LIST</b>: Use this type when the script has no input variables. In this case, only the callee numbers need to be provided. Example: <c>0571****5678,0571****5679</c>.</description></item>
        /// <item><description><b>JSON</b>: Use this type when the script includes input variables. You must provide the variable names, callee numbers, and variable values. Example: <c>{&quot;ParamNames&quot;:[&quot;name&quot;,&quot;age&quot;],&quot;CalleeList&quot;:[{&quot;Callee&quot;:&quot;181****0000&quot;,&quot;Params&quot;:[&quot;Zhang San&quot;,&quot;20&quot;]},{&quot;Callee&quot;:&quot;181****0001&quot;,&quot;Params&quot;:[&quot;Li Si&quot;,&quot;21&quot;]}]}</c>. <b>ParamNames</b> represents the list of parameter names; <b>Params</b> represents the list of parameter values.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can view the script input variables on the <a href="https://aiccs.console.aliyun.com/patter/list"><b>Script Management</b></a> &gt; <b>View</b> &gt; <b>Input and Output Parameters</b> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ParamNames&quot;: [
        ///     &quot;name&quot;,
        ///     &quot;age&quot;
        ///   ],
        ///   &quot;CalleeList&quot;: [
        ///     {
        ///       &quot;Callee&quot;: &quot;181<b><b>0000&quot;,
        ///       &quot;Params&quot;: [
        ///         &quot;张三&quot;,
        ///         &quot;20&quot;
        ///       ]
        ///     },
        ///     {
        ///       &quot;Callee&quot;: &quot;181</b></b>0001&quot;,
        ///       &quot;Params&quot;: [
        ///         &quot;李四&quot;,
        ///         &quot;21&quot;
        ///       ]
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("CallString")]
        [Validation(Required=false)]
        public string CallString { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The job ID. You can obtain the job ID from the <a href="https://aiccs.console.aliyun.com/job/list">Task Management</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
