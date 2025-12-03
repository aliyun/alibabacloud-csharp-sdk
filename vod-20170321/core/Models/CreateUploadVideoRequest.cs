// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the category. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b> to view the category ID of the media file.</description></item>
        /// <item><description>Obtain the value of CateId from the response to the <a href="~~AddCategory~~">AddCategory</a> operation.</description></item>
        /// <item><description>Obtain the value of CateId from the response to the <a href="~~GetCategories~~">GetCategories</a> operation.</description></item>
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
        /// <para>The description of the audio or video file.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 1,024 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UploadTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the source file.</para>
        /// <list type="bullet">
        /// <item><description>The name must contain a file name extension, which is not case-sensitive.</description></item>
        /// <item><description>For more information about file name extensions supported by ApsaraVideo VOD, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>.</description></item>
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
        /// <para>The size of the source file. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The storage address. Perform the following operations to obtain the storage address: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b>. On the Storage page, view the storage address.</para>
        /// <remarks>
        /// <para> If you leave this parameter empty, audio and video files are uploaded to the default storage address. If you specify a storage address, audio and video files are uploaded to the specified address.</para>
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
        /// <item><description>You can specify a maximum of 16 tags.</description></item>
        /// <item><description>If you want to specify multiple tags, separate the tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose Configuration Management &gt; Media Processing &gt; Transcoding Template Groups. On the Transcoding Template Groups page, you can view the ID of the transcoding template group.<a href="https://vod.console.aliyun.com"></a>************</description></item>
        /// <item><description>Obtain the value of the TranscodeTemplateGroupId parameter from the response to the <a href="https://help.aliyun.com/document_detail/102665.html">AddTranscodeTemplateGroup</a> operation that you called to create a transcoding template group.</description></item>
        /// <item><description>Obtain the value of the TranscodeTemplateGroupId parameter from the response to the <a href="https://help.aliyun.com/document_detail/102669.html">ListTranscodeTemplateGroup</a> operation that you called to query transcoding template groups.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify both WorkflowId and TemplateGroupId, the value of the WorkflowId parameter takes effect.</description></item>
        /// <item><description>If this parameter is not specified, transcoding is performed based on the default transcoding template group. If the transcoding template group ID is specified, transcoding is performed based on the specified template group.</description></item>
        /// <item><description>If the <b>No Transcoding</b> template group is used, only the <a href="https://help.aliyun.com/document_detail/55630.html">FileUploadComplete</a> event notification is returned after a video is uploaded. The <a href="https://help.aliyun.com/document_detail/55636.html">StreamTranscodeComplete</a> event notification is not returned.</description></item>
        /// <item><description>If you use the <b>No Transcoding</b> template group to upload videos, only videos in the format of MP4, FLV, MP3, M3U8, or WebM can be played. Videos in other formats can only be stored in ApsaraVideo VOD. You can view the file name extension to obtain the video format. If you want to use ApsaraVideo Player, make sure that the version of the player is V3.1.0 or later.</description></item>
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
        /// <para>The title of the audio or video file.</para>
        /// <list type="bullet">
        /// <item><description>The title can be up to 128 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
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
        /// <para>The custom configurations such as callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">Request parameters</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</description></item>
        /// <item><description>If you want to enable the upload acceleration feature, <a href="https://yida.alibaba-inc.com/o/ticketapply">submit a request on Yida</a>. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>.</description></item>
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
        /// <para>The ID of the workflow. To view the ID of the workflow, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Workflows</b>.</para>
        /// <remarks>
        /// <para>If you specify the WorkflowId and TemplateGroupId parameters, the value of the WorkflowId parameter takes effect. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Workflows</a>.</para>
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
