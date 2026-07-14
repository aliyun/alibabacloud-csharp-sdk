// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateFlowVersionRequest : TeaModel {
        /// <summary>
        /// <para>The tenant code. Default value: ALICOM_OPAAS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The extended business information. The default value is an empty collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizExtend { get; set; }

        /// <summary>
        /// <para>The code of the flow. View the flow code in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The version of the flow. In the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a>, click the flow name to open the canvas and view the flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// <para>The DSL data of the flow version, in JSON format. To obtain this data, orchestrate the components on the canvas in the Flow Editor. After you save the flow, click <b>Settings</b> &gt; <b>Export</b> in the upper-right corner of the canvas to export the flow as a JSON data file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;schema&quot;: {
        ///     &quot;namespace&quot;: &quot;External&quot;,
        ///     &quot;version&quot;: &quot;1.0&quot;,
        ///     &quot;copyright&quot;: &quot;Alibaba Cloud&quot;
        ///   },
        ///   &quot;editor&quot;: &quot;H4sIAAAAAAAAA+1YbU/c***********************&quot;,
        ///   &quot;flow&quot;: {
        ///     &quot;triggerType&quot;: &quot;TriggeredByWhatsApp&quot;
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("FlowViewModel")]
        [Validation(Required=false)]
        public string FlowViewModel { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The remarks for the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>修复发送WhatsApp消息错误</para>
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
