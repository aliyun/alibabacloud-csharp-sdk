// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateChatFlowLogSettingRequest : TeaModel {
        /// <summary>
        /// <para>The flow code. You can view the flow code in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The unique ID of the setting. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2937212.html">ReadChatFlowLogSetting</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>The log enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ENABLED: Enables log writing.</para>
        /// </description></item>
        /// <item><description><para>DISABLED: Disables log writing but retains the Simple Log Service log instance.</para>
        /// </description></item>
        /// <item><description><para>DELETED: Disables log writing and deletes the Simple Log Service log instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
