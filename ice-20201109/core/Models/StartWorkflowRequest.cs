// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip verification of the input path supported by the pipeline. This parameter takes effect only when the pipeline input is an OSS file. We recommend that you do not skip this verification to avoid faults caused by incorrect paths. If this parameter is not specified, verification is performed by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Skip verification</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not skip verification</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipInputVerification")]
        [Validation(Required=false)]
        public bool? SkipInputVerification { get; set; }

        /// <summary>
        /// <para>The workflow input. Only media assets are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Type&quot;: &quot;Media&quot;,
        ///       &quot;Media&quot;: &quot;<b><b><b>30706071edbfe290b488</b></b></b>&quot;
        /// } or
        /// {
        ///       &quot;Type&quot;: &quot;OSS&quot;,
        ///       &quot;Media&quot;: &quot;oss://bucket/path/to/video.mp4&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskInput")]
        [Validation(Required=false)]
        public string TaskInput { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format, which cannot be up to 512 bytes in length. You can specify a custom callback URL. For more information, see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or{&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the workflow template. To view the template ID, log on to the <a href="https://ims.console.aliyun.com/settings/workflow/list">IMS console</a> and choose Configurations &gt; Workflow Template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>f0e54971ecbffd472190</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
