// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Business tenant code, default is “ALICOM_OPAAS”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>Business extension information, default is “{}”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public string BizExtendShrink { get; set; }

        /// <summary>
        /// <para>Flow trigger type, enum values:</para>
        /// <list type="bullet">
        /// <item><description>TriggeredManually</description></item>
        /// <item><description>TriggeredByWhatsApp</description></item>
        /// <item><description>TriggeredByInstagram</description></item>
        /// <item><description>TriggeredByViber</description></item>
        /// <item><description>TriggeredByMessenger</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("FlowTriggerType")]
        [Validation(Required=false)]
        public string FlowTriggerType { get; set; }

        /// <summary>
        /// <para>Search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Whether to return the online status</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReturnWithOnlineVersion")]
        [Validation(Required=false)]
        public bool? ReturnWithOnlineVersion { get; set; }

        /// <summary>
        /// <para>Flow status</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
