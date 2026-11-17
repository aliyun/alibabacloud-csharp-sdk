// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatFlowByImportRequest : TeaModel {
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
        /// <para>The imported flow DSL data, which is a JSON-formatted string. You can orchestrate the flow components on the canvas in the Flow Editor in advance, save the flow, and then click <b>Settings</b> &gt; <b>Export</b> in the upper-right corner of the canvas to export and view it as a JSON data file.</para>
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
        /// <para>The remark of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trigger subscription</para>
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
        /// <para>The title of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WhatsApp trigger subscription</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
