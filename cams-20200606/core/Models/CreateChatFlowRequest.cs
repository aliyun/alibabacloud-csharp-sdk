// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatFlowRequest : TeaModel {
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
        /// <para>The source flowCode for creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("CreateFromFlowCode")]
        [Validation(Required=false)]
        public string CreateFromFlowCode { get; set; }

        /// <summary>
        /// <para>The source flowVersion for creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("CreateFromFlowVersion")]
        [Validation(Required=false)]
        public string CreateFromFlowVersion { get; set; }

        /// <summary>
        /// <para>The flow trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TriggeredManually</description></item>
        /// <item><description>TriggeredByWhatsApp</description></item>
        /// <item><description>TriggeredByMessenger</description></item>
        /// <item><description>TriggeredByInstagram</description></item>
        /// <item><description>TriggeredByViber</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TriggeredByWhatsApp</para>
        /// </summary>
        [NameInMap("FlowTriggerType")]
        [Validation(Required=false)]
        public string FlowTriggerType { get; set; }

        /// <summary>
        /// <para>The lifecycle extension input parameters.</para>
        /// </summary>
        [NameInMap("LifeCycleExtendData")]
        [Validation(Required=false)]
        public Dictionary<string, string> LifeCycleExtendData { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The flow remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Send verification template triggered by API</para>
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
        /// <para>The flow title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WhatsApp auto-reply</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
