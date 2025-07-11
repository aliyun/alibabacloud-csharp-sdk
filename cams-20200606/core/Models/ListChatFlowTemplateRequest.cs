// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatFlowTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Business tenant code, default is “ALICOM_OPAAS”.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>Search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
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
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>Trigger type, with the following enum values:</para>
        /// <list type="bullet">
        /// <item><description>TriggeredManually</description></item>
        /// <item><description>TriggeredByWhatsApp</description></item>
        /// <item><description>TriggeredByInstagram</description></item>
        /// <item><description>TriggeredByViber</description></item>
        /// <item><description>TriggeredByMessenger</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TriggeredByWhatsApp</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
