// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunNotifyComponentWithWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The name of the playbook action.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notifyByCustom</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>The ID of the resource. This parameter is deprecated and no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The name of the playbook component.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotifyMessage</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The content of the message sent by the webhook of the DingTalk group robot.</para>
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
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The message type of the webhook. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>text</para>
        /// </description></item>
        /// <item><description><para>markdown</para>
        /// </description></item>
        /// <item><description><para>actionCard</para>
        /// </description></item>
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
        /// <para>The name of the playbook node.</para>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/3000306.html">DescribePlaybooks</a> operation to obtain this parameter.</para>
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
        /// <para>The UID of the member that the administrator wants to switch to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>126339xxxx805497</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default): the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that belong to the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The secret key for the webhook of the DingTalk group robot. This parameter is deprecated and no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SECc1<em><b><b>e157b32b380f</b></b></em>***bb8c70e1a67a22072</para>
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// <para>The IDs of the DingTalk robots. Obtain the IDs on the robot management page in Message Center.</para>
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
