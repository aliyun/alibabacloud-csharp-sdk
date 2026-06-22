// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateMetricRequest : TeaModel {
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
        /// <para>The end of the time range to query. This is a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1693407714687</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The metric granularity. Valid values:</para>
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

        /// <summary>
        /// <para>The language of the template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1693107714687</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The template code. View the template code on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Template Design</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1100***************</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template type. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>WHATSAPP</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not pass this parameter, the default value WHATSAPP is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
