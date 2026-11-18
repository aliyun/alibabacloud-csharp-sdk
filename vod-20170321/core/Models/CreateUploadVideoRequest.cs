// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The category ID. You can obtain the category ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Asset Management Configuration</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>When you create a category by calling the <a href="~~AddCategory~~">AddCategory</a> operation, the category ID is the value of the CateId parameter in the response.</description></item>
        /// <item><description>When you query categories by calling the <a href="~~GetCategories~~">GetCategories</a> operation, the category ID is the value of the CateId parameter in the response.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100036****</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The URL of the custom video thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyundoc.com/image/D22F553TEST****.jpeg">https://example.aliyundoc.com/image/D22F553TEST****.jpeg</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the audio or video file displayed in ApsaraVideo VOD after the upload is complete.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 1,024 characters in length.</description></item>
        /// <item><description>The description must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UploadTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the first frame of the video as the thumbnail.</para>
        /// </summary>
        [NameInMap("EnableFirstFrameCover")]
        [Validation(Required=false)]
        public bool? EnableFirstFrameCover { get; set; }

        /// <summary>
        /// <para>The name of the audio or video source file to be uploaded.</para>
        /// <list type="bullet">
        /// <item><description>The file name must contain an extension. The extension is not case-sensitive.</description></item>
        /// <item><description>For supported extensions, see <a href="https://help.aliyun.com/document_detail/55396.html">Upload overview</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D:\video_01.mp4</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The size of the audio or video source file to be uploaded. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a thumbnail for the video.</para>
        /// </summary>
        [NameInMap("GenerateThumbnail")]
        [Validation(Required=false)]
        public bool? GenerateThumbnail { get; set; }

        /// <summary>
        /// <para>The custom ID. The ID can be 6 to 64 characters in length and can contain only lowercase letters, uppercase letters, digits, hyphens (-), and underscores (_). The ID must be unique within the user dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The storage address. You can obtain the storage address by using the following method:
        /// Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Asset Management Configuration</b> &gt; <b>Storage Management</b> to view the storage address.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the audio or video file is uploaded to the default storage address. If no default storage address is configured, the file is uploaded to the first storage address in the storage list. If you specify this parameter, the audio or video file is uploaded to the specified storage address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The tags of the audio or video file.</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 16 tags.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 characters in length.</description></item>
        /// <item><description>The tags must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing Configuration</b> &gt; <b>Transcoding Template Groups</b> to view the ID of the transcoding template group.</description></item>
        /// <item><description>When you create a transcoding template group by calling the <a href="https://help.aliyun.com/document_detail/102665.html">Create a transcoding template group</a> operation, the ID is the value of the TranscodeTemplateGroupId parameter in the response.</description></item>
        /// <item><description>When you query transcoding template groups by calling the <a href="https://help.aliyun.com/document_detail/102669.html">Query transcoding configuration list</a> operation, the ID is the value of the TranscodeTemplateGroupId parameter in the response.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If both WorkflowId and TemplateGroupId are specified, WorkflowId takes precedence.</description></item>
        /// <item><description>If you do not specify this parameter, the default transcoding template group is used. If you specify this parameter, the specified transcoding template group is used.</description></item>
        /// <item><description>If you set this parameter to the built-in <b>No Transcoding</b> template group, only the <a href="https://help.aliyun.com/document_detail/55630.html">video upload completion</a> event notification is generated after the audio or video file is uploaded. The <a href="https://help.aliyun.com/document_detail/55636.html">single definition transcoding completion</a> event notification is not generated.</description></item>
        /// <item><description>The task triggered by this parameter is an <a href="https://help.aliyun.com/document_detail/3027551.html">asynchronous task</a>. After the task is submitted, it is queued and executed asynchronously in the background.</description></item>
        /// <item><description>To ensure normal playback, if you set this parameter to the built-in <b>No Transcoding</b> template group, only the following formats support direct playback without transcoding after the audio or video file is uploaded: MP4, FLV, MP3, M3U8, and WEBM. Other formats are only supported for storage (pay attention to the extension of FileName). If you use ApsaraVideo Player for playback, the version must be 3.1.0 or later.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>405477f9e214d19ea2c7c854****</para>
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// <para>The title of the audio or video file displayed in ApsaraVideo VOD after the upload is complete.</para>
        /// <list type="bullet">
        /// <item><description>The title can be up to 128 characters in length.</description></item>
        /// <item><description>The title must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UploadTest</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports settings such as message callback and upload acceleration. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To use the message callback feature, you must configure an HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect. If no callback URL is specified for subsequent tasks, notifications are pushed to this URL by default. For more information about how to configure HTTP callbacks in the console, see <a href="https://help.aliyun.com/document_detail/86071.html">Callback settings</a>.</description></item>
        /// <item><description>To use the upload acceleration feature, you must <a href="https://yida.alibaba-inc.com/o/ticketapply">submit an application</a> to enable it. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Upload instructions</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The workflow ID. You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing Configuration</b> &gt; <b>Workflows</b> to view the workflow ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If both WorkflowId and TemplateGroupId are specified, WorkflowId takes precedence. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Workflows</a>.</description></item>
        /// <item><description>The task triggered by this parameter is an <a href="https://help.aliyun.com/document_detail/3027551.html">asynchronous task</a>. After the task is submitted, it is queued and executed asynchronously in the background.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>613efff3887ec34af685714cc461****</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
