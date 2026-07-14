// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMarketingFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The campaign code. You can use the system code or modify it to use a custom code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rewrwerw</para>
        /// </summary>
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        /// <summary>
        /// <para>The name of the node task instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>werewew</para>
        /// </summary>
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// <para>The campaign status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sucess</para>
        /// </summary>
        [NameInMap("ActivityStatus")]
        [Validation(Required=false)]
        public string ActivityStatus { get; set; }

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
        /// <para>The business extension information. Default value: &quot;{}&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public string BizExtendShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public string PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the associated flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdfsdfdsfs</para>
        /// </summary>
        [NameInMap("RelatedFlowCode")]
        [Validation(Required=false)]
        public string RelatedFlowCode { get; set; }

        /// <summary>
        /// <para>The ID of the associated group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("RelatedGroupId")]
        [Validation(Required=false)]
        public long? RelatedGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
