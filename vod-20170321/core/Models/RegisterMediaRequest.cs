// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaRequest : TeaModel {
        /// <summary>
        /// <para>The metadata of the media files. The value must be a JSON string. You can specify the metadata for up to 10 media files at a time. For more information about the metadata of media files, see the <b>RegisterMetadata</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FileURL&quot;:&quot;https://****.oss-cn-shanghai.aliyuncs.com/video/test/video123.m3u8&quot;,&quot;Title&quot;:&quot;VideoName&quot;}]</para>
        /// </summary>
        [NameInMap("RegisterMetadatas")]
        [Validation(Required=false)]
        public string RegisterMetadatas { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Transcoding Template Groups</b>. On the Transcoding Template Groups page, you can view the ID of the transcoding template group.</description></item>
        /// <item><description>Obtain the value of the TranscodeTemplateGroupId parameter from the response to the <a href="https://help.aliyun.com/document_detail/102665.html">AddTranscodeTemplateGroup</a> operation that you called to create a transcoding template group.</description></item>
        /// <item><description>Obtain the value of the TranscodeTemplateGroupId parameter from the response to the <a href="https://help.aliyun.com/document_detail/102669.html">ListTranscodeTemplateGroup</a> operation that you called to query transcoding template groups.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not need to transcode media files, set the TemplateGroupId parameter to VOD_NO_TRANSCODE. If you do not specify this configuration, errors occur on your files. If you need to transcode media files, specify the ID of the transcoding template group.</para>
        /// </description></item>
        /// <item><description><para>If you specify both WorkflowId and TemplateGroupId, the value of the WorkflowId parameter takes effect. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Workflows</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e49c87b65806709586****</para>
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// <para>The custom settings. The value must be a JSON string. You can configure settings such as message callbacks. For more information, see <a href="~~86952#section_6fg_qll_v3w~~">UserData</a>.</para>
        /// <remarks>
        /// <para> You cannot configure callbacks for this operation. No callback message is returned after the media files are registered even if you configure callback settings for this parameter. If you configure callback settings for the UserData parameter when you create media processing jobs such as transcoding and snapshot capture jobs for the media file, the callback URL that you specified is used. If you do not configure callback settings when you create media processing jobs, the callback URL that you specified for the UserData parameter when you register the media file is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the workflow. To view the workflow ID, perform the following steps: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Workflows</b>.</para>
        /// <remarks>
        /// <para> If you specify both WorkflowId and TemplateGroupId, the value of WorkflowId parameter takes effect. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Workflows</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>637adc2b7ba51a83d841606f8****</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
