// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateFlowVersionShrinkRequest : TeaModel {
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
        public string BizExtendShrink { get; set; }

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
        /// <para>The flow version. You can click the flow name on the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page to go to the canvas page and view the flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// <para>The DSL data of the flow version. The data is in JSON format. You can orchestrate flow components on the canvas in the flow editor in advance, save the flow, and then click <b>Settings</b> &gt; <b>Export</b> in the upper-right corner of the canvas to export the data as a JSON data file for viewing.</para>
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
        /// <para>The version remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fix the error in sending WhatsApp messages</para>
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

        /// <summary>
        /// <para>The save type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value sample value sample value</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
