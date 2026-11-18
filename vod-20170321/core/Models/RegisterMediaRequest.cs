// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the first frame of the video as the thumbnail.</para>
        /// </summary>
        [NameInMap("EnableFirstFrameCover")]
        [Validation(Required=false)]
        public bool? EnableFirstFrameCover { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a thumbnail for the video.</para>
        /// </summary>
        [NameInMap("GenerateThumbnail")]
        [Validation(Required=false)]
        public bool? GenerateThumbnail { get; set; }

        /// <summary>
        /// <para>The metadata of the media assets to be registered. The value is a JSON string. You can specify the metadata for up to 10 media assets at a time. For more information about the parameter structure, see the <b>RegisterMetadata</b> table below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FileURL&quot;:&quot;https://****.oss-cn-shanghai.aliyuncs.com/video/test/video123.m3u8&quot;,&quot;Title&quot;:&quot;VideoName&quot;}]</para>
        /// </summary>
        [NameInMap("RegisterMetadatas")]
        [Validation(Required=false)]
        public string RegisterMetadatas { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing Configuration</b> &gt; <b>Transcoding Template Groups</b> to view the ID of the transcoding template group.</description></item>
        /// <item><description>When you create a transcoding template group by calling the <a href="https://help.aliyun.com/document_detail/102665.html">Create a transcoding template group</a> operation, the ID of the transcoding template group is the value of the TranscodeTemplateGroupId response parameter.</description></item>
        /// <item><description>When you query transcoding template groups by calling the <a href="https://help.aliyun.com/document_detail/102669.html">Query transcoding configurations</a> operation, the ID of the transcoding template group is the value of the TranscodeTemplateGroupId response parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If transcoding is not required, set this parameter to VOD_NO_TRANSCODE, which specifies the no-transcoding template group. Otherwise, the video status is <b>Upload Completed</b>, and you cannot use the playback service to play the audio or video. If transcoding is required, specify the ID of the corresponding transcoding template group.</description></item>
        /// <item><description>If both WorkflowId and TemplateGroupId are specified, WorkflowId takes precedence. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Media workflows</a>.</description></item>
        /// <item><description>The task for this parameter is an <a href="https://help.aliyun.com/document_detail/3027551.html">asynchronous task</a>. After the task is submitted, it is not immediately completed but queued for asynchronous execution in the background.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e49c87b65806709586****</para>
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string. You can configure settings such as message callbacks. For more information about the parameter, see <a href="~~86952#section_6fg_qll_v3w~~">UserData</a>.</para>
        /// <remarks>
        /// <para>This operation does not support callbacks. Even if a message callback is configured in this parameter, no callback message is generated after the media asset registration is completed. When you subsequently initiate media processing such as transcoding and snapshot generation for the registered media assets, if you separately configure a message callback in UserData when initiating the transcoding or snapshot generation, that callback URL takes precedence. If no callback is separately configured, the callback URL configured in UserData during the media asset registration is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the media workflow. You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing Configuration</b> &gt; <b>Workflow Management</b> to view the workflow ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If both WorkflowId and TemplateGroupId are specified, WorkflowId takes precedence. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Media workflows</a>.</description></item>
        /// <item><description>The task for this parameter is an <a href="https://help.aliyun.com/document_detail/3027551.html">asynchronous task</a>. After the task is submitted, it is not immediately completed but queued for asynchronous execution in the background.</description></item>
        /// </list>
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
