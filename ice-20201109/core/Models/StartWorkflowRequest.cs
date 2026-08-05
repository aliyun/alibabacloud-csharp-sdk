// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip the input path verification for the workflow. This parameter takes effect only when the workflow input is an OSS file. We recommend that you do not skip the verification to avoid errors caused by incorrect paths. If this parameter is not specified, the default value is false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Skip the verification.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not skip the verification.</para>
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
        /// <para>The workflow input. Currently, media asset types and OSS files are supported.</para>
        /// <para>Type: the supported media object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OSS: an OSS file.</para>
        /// </description></item>
        /// <item><description><para>Media: a media asset ID.</para>
        /// </description></item>
        /// </list>
        /// <para>Media: the media value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If Type is set to OSS, the value is a URL that supports the OSS protocol and HTTP protocol.</para>
        /// </description></item>
        /// <item><description><para>If Type is set to Media, the value is a media asset ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Type&quot;: &quot;Media&quot;,
        ///       &quot;Media&quot;: &quot;<b><b><b>30706071edbfe290b488</b></b></b>&quot;
        /// } or
        /// {
        ///       &quot;Type&quot;: &quot;OSS&quot;,
        ///       &quot;Media&quot;: &quot;oss://bucket.oss-ap-southeast-1.aliyuncs.com/A/B/C/test1.flv&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskInput")]
        [Validation(Required=false)]
        public string TaskInput { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. The maximum length is 512 bytes. <a href="https://help.aliyun.com/document_detail/451631.html">Custom callback URL configuration</a> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The workflow template ID. You can view the template ID in the <a href="https://ims.console.aliyun.com/settings/workflow/list">Intelligent Media Services console</a> by navigating to Configuration Management &gt; Workflow Template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>f0e54971ecbffd472190</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
