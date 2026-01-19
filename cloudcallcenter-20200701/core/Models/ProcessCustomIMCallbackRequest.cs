// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class ProcessCustomIMCallbackRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>420F203D-87ED-599A-B137-D9D914EE9E70</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27578380-d382-11ee-9cca-adec43112a87</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ContentType&quot;: &quot;Text&quot;,
        ///     &quot;Text&quot;: &quot;Hello&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("MessageContent")]
        [Validation(Required=false)]
        public string MessageContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FCEFE806-E67C-577E-865B-4ED398F2F648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FCEFE806-E67C-577E-865B-4ED398F2F648</para>
        /// </summary>
        [NameInMap("SenderAvatarMediaId")]
        [Validation(Required=false)]
        public string SenderAvatarMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>654f1054dcda1b251282cbdf</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tom</para>
        /// </summary>
        [NameInMap("SenderName")]
        [Validation(Required=false)]
        public string SenderName { get; set; }

    }

}
