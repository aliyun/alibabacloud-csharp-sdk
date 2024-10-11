// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIMediaAuditJobRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information about the review job.</para>
        /// <list type="bullet">
        /// <item><description>Other configuration items of the review job. Only the ResourceType field is supported. This field is used to specify the type of media files. You can adjust review standards and rules based on the type of media files.</description></item>
        /// <item><description>If you want to modify the review standard and rules based on ResourceType, submit a ticket. For more information, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
        /// <item><description>The value of ResourceType can contain only letters, digits, and underscores (_).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ResourceType&quot;:&quot;****_movie&quot;}</para>
        /// </summary>
        [NameInMap("MediaAuditConfiguration")]
        [Validation(Required=false)]
        public string MediaAuditConfiguration { get; set; }

        /// <summary>
        /// <para>The ID of the video file. To obtain the file ID, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Review Management</b> &gt; <b>Content Moderation</b> in the left-side navigation pane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe028d09441afffb138cd7ee****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the media file. Only <b>video</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The ID of the AI template. You can use one of the following methods to obtain the ID of the AI template:</para>
        /// <list type="bullet">
        /// <item><description>Obtain the value of TemplateId from the response to the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> operation that you call to create an AI template.</description></item>
        /// <item><description>Obtain the value of TemplateId from the response to the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation that you call to create an AI template.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify an ID, the ID of the default AI template is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a07a7f7d7d10eb9fd999e56ecc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The custom settings. The value must be a JSON string. You can configure settings such as message callbacks. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <para> To use the callback configurations specified by this parameter, you must configure an HTTP callback URL and specify the types of the callback events in the ApsaraVideo VOD console. Otherwise, the callback configurations do not take effect. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://test.test.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://test.test.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
