// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunNotifyComponentWithWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The name of the action in the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notifyByCustom</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>The ID of the resource. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The name of the component in the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotifyMessage</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The message body sent by the DingTalk group chatbot webhook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;at&quot;: {
        ///         &quot;atMobiles&quot;:[
        ///             &quot;180xxxxxx&quot;
        ///         ],
        ///         &quot;atUserIds&quot;:[
        ///             &quot;user123&quot;
        ///         ],
        ///         &quot;isAtAll&quot;: false
        ///     },
        ///     &quot;text&quot;: {
        ///         &quot;content&quot;:&quot;1234&quot;
        ///     },
        ///     &quot;msgtype&quot;:&quot;text&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of the webhook message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text.</description></item>
        /// <item><description>markdown.</description></item>
        /// <item><description>actionCard.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// <para>The name of the node in the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notify_message_node</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to query the UUIDs of playbooks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94bc318c-<b><b>-4cba-</b></b>-801ccb0d739f</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The ID of the user who switches from the current view to the destination view by using the management account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>126339xxxx805497</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts for the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The message key of the DingTalk chatbot webhook. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SECc1<em><b><b>e157b32b380f</b></b></em>***bb8c70e1a67a22072</para>
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// <para>The IDs of chatbots that are configured in the message center. Only DingTalk chatbots are supported.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListEncryptWebhooks~~">ListEncryptWebhooks</a> operation to query the chatbot IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;10651\&quot;]</para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
