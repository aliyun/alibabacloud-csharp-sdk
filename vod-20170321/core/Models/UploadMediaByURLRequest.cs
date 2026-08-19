// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EnableFirstFrameCover")]
        [Validation(Required=false)]
        public bool? EnableFirstFrameCover { get; set; }

        [NameInMap("GenerateThumbnail")]
        [Validation(Required=false)]
        public bool? GenerateThumbnail { get; set; }

        /// <summary>
        /// <para>The custom deduplication identifier. If this parameter is specified and a request with the same identifier was sent within the past 10 minutes, an error is returned for the current request.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This deduplication identifier is custom-defined. It can be up to 50 characters in length and can contain uppercase and lowercase letters, digits, hyphens (-), and underscores (_). If this parameter is not specified or is set to an empty string, deduplication is not performed.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5c62d40299034bbaa4c195da330****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The storage address of the media file.</para>
        /// <para>Log on to the <a href="https://vod.console.aliyun.com/?spm=a2c4g.11186623.2.15.6948257eaZ4m54#/vod/settings/censored">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Asset Management</b> &gt; <b>Storage</b> to view the storage address. If you do not specify this parameter, the default storage address is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outin-bfefbb90a47c******163e1c7426.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Transcoding Template Groups</b> to view the transcoding template group ID.</description></item>
        /// <item><description>Obtain the value of TranscodeTemplateGroupId from the response when you call the <a href="https://help.aliyun.com/document_detail/102665.html">AddTranscodeTemplateGroup</a> operation.</description></item>
        /// <item><description>Obtain the value of TranscodeTemplateGroupId from the response when you call the <a href="https://help.aliyun.com/document_detail/102669.html">ListTranscodeTemplateGroup</a> operation.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify a transcoding template group ID, the default transcoding template group is used. If you specify a transcoding template group ID, the specified template group is used.</description></item>
        /// <item><description>You can also set this parameter in <c>UploadMetadatas</c>. If TemplateGroupId is set in both UploadMetadatas and this parameter, the value in UploadMetadatas takes precedence.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e4957b65806709586****</para>
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// <para>The metadata of the media files to upload. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>The metadata takes effect only when it matches a URL in UploadURLs.</description></item>
        /// <item><description>JSON format: <c>[UploadMetadata, UploadMetadata,…]</c>. The value must be converted to a JSON string.</description></item>
        /// <item><description>For more information, see the <b>UploadMetadata</b> table below.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SourceURL&quot;:&quot;<a href="https://example.aliyundoc.com/video01.mp4%22,%22Title%22:%22urlUploadTest%22%7D%5D">https://example.aliyundoc.com/video01.mp4&quot;,&quot;Title&quot;:&quot;urlUploadTest&quot;}]</a></para>
        /// </summary>
        [NameInMap("UploadMetadatas")]
        [Validation(Required=false)]
        public string UploadMetadatas { get; set; }

        /// <summary>
        /// <para>The URLs of media source files.</para>
        /// <list type="bullet">
        /// <item><description>The URL must include a file name extension. For example, mp4 is the file name extension in <c>https://****.mp4</c>.<list type="bullet">
        /// <item><description>If the URL does not include a file name extension, you can specify the FileExtension parameter in <c>UploadMetadatas</c>.</description></item>
        /// <item><description>If the URL includes a file name extension and the <c>FileExtension</c> parameter is also specified, the value of <c>FileExtension</c> takes precedence.</description></item>
        /// <item><description>For supported file name extensions, see <a href="https://help.aliyun.com/document_detail/55396.html">Upload overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Separate multiple URLs with commas (,). A maximum of 20 URLs are supported. To prevent upload failures caused by special characters, URL-encode each URL before joining them with commas.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://****.mp4</para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports message callback and upload acceleration settings. For more information, see <a href="~~86952#UserData~~">UserData</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To use message callbacks in this parameter, you must configure an HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect. For information about how to configure HTTP callbacks in the console, see <a href="https://help.aliyun.com/document_detail/86071.html">Callback settings</a>.</description></item>
        /// <item><description>To use the upload acceleration feature, submit a ticket to activate it. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Upload instructions</a>. For information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The workflow ID. Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Workflows</b> to view the workflow ID.</para>
        /// <remarks>
        /// <para>If both WorkflowId and TemplateGroupId are specified, WorkflowId takes precedence. For usage instructions, see <a href="https://help.aliyun.com/document_detail/115347.html">Workflows</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e1e243b42548248197d6f74f9****</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
