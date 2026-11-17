// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateFlowVersionRequest : TeaModel {
        /// <summary>
        /// <para>The business tenant code. Default value: ALICOM_OPAAS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The business extension information. Default value: an empty collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizExtend { get; set; }

        /// <summary>
        /// <para>The flow code. You can view the flow code on the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The flow version to copy. You can click the flow name on the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page to go to the canvas orchestration page and view the historical versions of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersionCopyFrom")]
        [Validation(Required=false)]
        public string FlowVersionCopyFrom { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The version remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fixed WhatsApp message sending errors</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
