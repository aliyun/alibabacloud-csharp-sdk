// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class UpdateUserSubscriptionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application name of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yunge-user</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The business line of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The request protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("CallerProtocol")]
        [Validation(Required=false)]
        public string CallerProtocol { get; set; }

        /// <summary>
        /// <para>The list of categories.</para>
        /// </summary>
        [NameInMap("CategoryCodes")]
        [Validation(Required=false)]
        public string CategoryCodesShrink { get; set; }

        /// <summary>
        /// <para>The list of channels.</para>
        /// </summary>
        [NameInMap("ChannelConfigs")]
        [Validation(Required=false)]
        public string ChannelConfigsShrink { get; set; }

        /// <summary>
        /// <para>The channel group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tts: Voice channel group.</description></item>
        /// <item><description>webhook: Chatbot channel group.</description></item>
        /// <item><description>base: Basic channel group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("ChannelGroupCode")]
        [Validation(Required=false)]
        public string ChannelGroupCode { get; set; }

        /// <summary>
        /// <para>The source of the operation terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("ClientSource")]
        [Validation(Required=false)]
        public string ClientSource { get; set; }

        /// <summary>
        /// <para>The common contacts.</para>
        /// </summary>
        [NameInMap("CommonContacts")]
        [Validation(Required=false)]
        public string CommonContactsShrink { get; set; }

        /// <summary>
        /// <para>The user cookies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string Cookies { get; set; }

        /// <summary>
        /// <para>The revision type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>receive_contact: Receive contact.</description></item>
        /// <item><description>receive_channel: Receive channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>receive_channel</para>
        /// </summary>
        [NameInMap("OperationItemCode")]
        [Validation(Required=false)]
        public string OperationItemCode { get; set; }

        /// <summary>
        /// <para>Not supported.</para>
        /// </summary>
        [NameInMap("ReceiveTimeList")]
        [Validation(Required=false)]
        public string ReceiveTimeListShrink { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The URL of the source page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("SrcUrl")]
        [Validation(Required=false)]
        public string SrcUrl { get; set; }

        /// <summary>
        /// <para>The tenant information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

        /// <summary>
        /// <para>The user type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("UidType")]
        [Validation(Required=false)]
        public string UidType { get; set; }

        /// <summary>
        /// <para>The list of chatbot contacts.</para>
        /// </summary>
        [NameInMap("WebhookContacts")]
        [Validation(Required=false)]
        public string WebhookContactsShrink { get; set; }

    }

}
