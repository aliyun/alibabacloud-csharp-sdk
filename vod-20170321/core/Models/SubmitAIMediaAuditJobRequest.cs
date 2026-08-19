// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIMediaAuditJobRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the review job.</para>
        /// <list type="bullet">
        /// <item><description>Other configuration items of the review job. Currently, only the ResourceType field is supported, which is used to specify the media file type. You can adjust the review standards and rules for this type.</description></item>
        /// <item><description>To adjust the review standards and rules for ResourceType, submit a ticket for technical support. For information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
        /// <item><description>Usage notes for ResourceType: Only letters, digits, and underscores (_) are allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ResourceType&quot;:&quot;****_movie&quot;}</para>
        /// </summary>
        [NameInMap("MediaAuditConfiguration")]
        [Validation(Required=false)]
        public string MediaAuditConfiguration { get; set; }

        /// <summary>
        /// <para>The audio or video ID. Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Review Management</b> &gt; <b>Video Review</b> to view the audio or video ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe028d09441afffb138cd7ee****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The media type. Currently, only <b>video</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The AI template ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> operation to add an AI template, the AI template ID is the value of the TemplateId response parameter.</description></item>
        /// <item><description>After the AI template is added, call the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation to query the AI template ID, which is the value of the TemplateId response parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify an AI template ID, the default AI template ID for automated review is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a07a7f7d7d10eb9fd999e56ecc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports settings such as message callbacks. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <para>To use the message callback in this parameter, you must configure an HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect. For information about how to configure HTTP callbacks in the console, see <a href="https://help.aliyun.com/document_detail/86071.html">Callback settings</a>.</para>
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
