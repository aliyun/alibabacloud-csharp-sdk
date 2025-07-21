// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListBindingRelationsForFlowVersionRequest : TeaModel {
        /// <summary>
        /// <para>Channel type. Values:</para>
        /// <list type="bullet">
        /// <item><description>INSTAGRAM</description></item>
        /// <item><description>WHATSAPP</description></item>
        /// <item><description>MESSENGER</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;- VIBER</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>Process code. View the process code in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
