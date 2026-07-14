// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappMessageRequest : TeaModel {
        /// <summary>
        /// <para>The business phone number.</para>
        /// <list type="bullet">
        /// <item><description>For WhatsApp channels, view the business phone number in the <a href="https://chatapp.console.aliyun.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>WABA Management</b> &gt; <b>Phone Number Management</b> console.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;- For Viber channels, view the Service ID in the <a href="https://chatapp.console.aliyun.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Service Account Management</b> console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800****</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whatsapp</b></para>
        /// </description></item>
        /// <item><description><para><b>viber</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The message receiving status of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ClientAcceptStatus")]
        [Validation(Required=false)]
        public string ClientAcceptStatus { get; set; }

        /// <summary>
        /// <para>The space ID of the ISV sub-customer or the instance ID of the direct customer. View the Space ID in the <a href="https://chatapp.console.aliyun.com/CustomerList">Channel Management</a> console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-************</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The end time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727057232686</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-30 00:00:00</para>
        /// </summary>
        [NameInMap("EndTimeStr")]
        [Validation(Required=false)]
        public string EndTimeStr { get; set; }

        /// <summary>
        /// <para>The message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOWN: outbound message.</description></item>
        /// <item><description>UP: inbound message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UP</para>
        /// </summary>
        [NameInMap("EventAction")]
        [Validation(Required=false)]
        public string EventAction { get; set; }

        /// <summary>
        /// <para>The bulk message ID. View the bulk message ID in the <a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Message List</b> &gt; <b>Bulk Sending List</b> console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9292****</para>
        /// </summary>
        [NameInMap("GroupMessageId")]
        [Validation(Required=false)]
        public string GroupMessageId { get; set; }

        /// <summary>
        /// <para>The message status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("MessageStatus")]
        [Validation(Required=false)]
        public string MessageStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The pagination object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListChatappMessageRequestPage Page { get; set; }
        public class ListChatappMessageRequestPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727057232686</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTimeStr")]
        [Validation(Required=false)]
        public string StartTimeStr { get; set; }

        /// <summary>
        /// <para>The template code. View the template code in the <a href="https://chatapp.console.aliyun.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Template Design</b> console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9938***</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The user phone number. This is the phone number that you imported when sending messages in the <a href="https://chatapp.console.aliyun.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Message Sending</b> console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86138***</para>
        /// </summary>
        [NameInMap("UserNumber")]
        [Validation(Required=false)]
        public string UserNumber { get; set; }

    }

}
