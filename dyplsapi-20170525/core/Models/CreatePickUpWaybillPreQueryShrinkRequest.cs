// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryShrinkRequest : TeaModel {
        /// <summary>
        /// The consignee information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public string ConsigneeInfoShrink { get; set; }

        /// <summary>
        /// The code of the courier company. If no courier company is specified, the system allocates a courier company.
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// The identifier of the external channel source. It cannot contain underscores.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// The order number of the access system.
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// The estimated weight. Unit: gram.
        /// 
        /// >  If you need to query the estimated price, this parameter is required.
        /// </summary>
        [NameInMap("PreWeight")]
        [Validation(Required=false)]
        public string PreWeight { get; set; }

        /// <summary>
        /// The sender information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public string SenderInfoShrink { get; set; }

    }

}
