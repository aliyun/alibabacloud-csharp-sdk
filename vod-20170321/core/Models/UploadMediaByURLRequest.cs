// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The custom identifier for deduplication. If you specify this parameter and send a request, an error is returned if a request with the same identifier was sent in the last 10 minutes. A custom identifier can be up to 50 characters in length and can contain letters, digits, hyphens (-), and underscores (_). If you do not specify this parameter or leave this parameter empty, duplicate requests are not filtered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c62d40299034bbaa4c195da330****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The storage address of the media file.</para>
        /// <para>To view the storage address, log on to the <a href="https://vod.console.aliyun.com/?spm=a2c4g.11186623.2.15.6948257eaZ4m54#/vod/settings/censored">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b>. If you do not specify a storage address, the default storage address is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outin-bfefbb90a47c******163e1c7426.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. You can use one of the following methods to obtain the ID of the transcoding template group:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Transcoding Template Groups</b>. On the Transcoding Template Groups page, view the ID of the transcoding template group.</description></item>
        /// <item><description>Obtain the value of TranscodeTemplateGroupId from the response to the <a href="https://help.aliyun.com/document_detail/102665.html">AddTranscodeTemplateGroup</a> operation.</description></item>
        /// <item><description>Obtain the value of TranscodeTemplateGroupId from the response to the <a href="https://help.aliyun.com/document_detail/102669.html">ListTranscodeTemplateGroup</a> operation.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the default transcoding template group is used for transcoding. If you specify this parameter, the specified transcoding template group is used for transcoding.</description></item>
        /// <item><description>You can also specify the ID of the transcoding template group in <c>UploadMetadatas</c>. If you specify this parameter and TemplateGroupId in UploadMetadatas, the TemplateGroupId in UploadMetadatas takes effect.</description></item>
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
        /// <para>The metadata of the media file that you want to upload. The value must be a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if SourceURL matches the URL that you specified for UploadURLs.</description></item>
        /// <item><description>You must convert the JSON-formatted data such as <c>[UploadMetadata, UploadMetadata,…]</c> to a JSON string.</description></item>
        /// <item><description>For more information, see the <b>UploadMetadata</b> table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SourceURL&quot;:&quot;<a href="https://example.aliyundoc.com/video01.mp4%22,%22Title%22:%22urlUploadTest%22%7D%5D">https://example.aliyundoc.com/video01.mp4&quot;,&quot;Title&quot;:&quot;urlUploadTest&quot;}]</a></para>
        /// </summary>
        [NameInMap("UploadMetadatas")]
        [Validation(Required=false)]
        public string UploadMetadatas { get; set; }

        /// <summary>
        /// <para>The URL of the media file.</para>
        /// <list type="bullet">
        /// <item><description><para>You must include a file name extension in the URL, such as <c>https://****.mp4</c>.</para>
        /// <list type="bullet">
        /// <item><description>If the URL does not contain a file name extension, specify a file name extension for <c>FileExtension</c> in <c>UploadMetadatas</c>.</description></item>
        /// <item><description>If you specify <c>FileExtension</c> when the URL contains a file name extension, the file name extension that you specified for <c>FileExtension</c> takes effect.</description></item>
        /// <item><description>For more information about file name extensions supported by ApsaraVideo VOD, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>URL encoding is required. Separate multiple URLs with commas (,). You can specify a maximum of 20 URLs.</para>
        /// </description></item>
        /// <item><description><para>Special characters may cause upload failures. You must encode URLs before you separate them with commas (,).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://****.mp4</para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// <para>The custom configurations such as callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see <a href="~~86952#UserData~~">Request parameters</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</description></item>
        /// <item><description>If you want to enable the upload acceleration feature, <a href="https://yida.alibaba-inc.com/o/ticketapply">submit a request on Yida</a>. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>.</description></item>
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
        /// <para>The ID of the workflow. To view the ID of the workflow, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Workflows</b>.</para>
        /// <remarks>
        /// <para>If you specify WorkflowId and TemplateGroupId, the value of WorkflowId takes effect. For more information, see <a href="https://help.aliyun.com/document_detail/115347.html">Workflows</a>.</para>
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
