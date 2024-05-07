// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GoodsShippingNoticeCreateCmd : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("logisticsNo")]
        [Validation(Required=false)]
        public string LogisticsNo { get; set; }

    }

}
