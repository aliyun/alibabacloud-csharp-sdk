// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ShopCreateRequest : TeaModel {
        [NameInMap("afterSaleDingTalkId")]
        [Validation(Required=false)]
        public string AfterSaleDingTalkId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorDingTalkId")]
        [Validation(Required=false)]
        public string OperatorDingTalkId { get; set; }

        [NameInMap("preSaleDingTalkId")]
        [Validation(Required=false)]
        public string PreSaleDingTalkId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

    }

}
