// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappPhoneNumberMetricRequest : TeaModel {
        /// <summary>
        /// <para>The Space ID or instance ID of the ISV sub-customer. This is the channel ID. View the channel ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-************</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758902399000</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The granularity of the metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DAILY: Metrics are collected by day.</para>
        /// </description></item>
        /// <item><description><para>HALF_HOUR: Metrics are collected every half an hour.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The independent software vendor (ISV) verification code, which is used to verify whether the user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikd****</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The business phone number. This is the phone number used to send messages. You can view the phone number in the ChatApp console by choosing &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>WABA Management</b> &gt; <b>Phone Number Management</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861380000****</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1756742399000</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
