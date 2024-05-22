// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsSaleControlShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AliUidAccount")]
        [Validation(Required=false)]
        public string AliUidAccount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SaleControls")]
        [Validation(Required=false)]
        public string SaleControlsShrink { get; set; }

    }

}
