// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListFlowNodePrototypeV2Request : TeaModel {
        /// <summary>
        /// <para>The business tenant code. The default value is ALICOM_OPAAS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The code for the component group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Messaging: Message components.</para>
        /// </description></item>
        /// <item><description><para>Core: Core components.</para>
        /// </description></item>
        /// <item><description><para>Intelligence: Intelligence components.</para>
        /// </description></item>
        /// <item><description><para>Contact: Contact management components.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Core</para>
        /// </summary>
        [NameInMap("GroupCode")]
        [Validation(Required=false)]
        public string GroupCode { get; set; }

        /// <summary>
        /// <para>The search keyword. This parameter is used to perform a fuzzy query by flow component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WhatsApp</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
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

    }

}
