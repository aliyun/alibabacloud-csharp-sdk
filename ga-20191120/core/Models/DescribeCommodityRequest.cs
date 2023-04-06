// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityRequest : TeaModel {
        /// <summary>
        /// The commodity code.
        /// 
        /// Examples for the China site (aliyun.com):
        /// 
        /// *   **ga_gapluspre_public_cn**: GA instance.
        /// *   **ga_plusbwppre_public_cn**: basic bandwidth plan.
        /// 
        /// Examples for the international site (alibabacloud.com):
        /// 
        /// *   **ga_pluspre_public_intl**: GA instance.
        /// *   **ga_bwppreintl_public_intl**: basic bandwidth plan.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The type of the order. Valid values:
        /// 
        /// *   **BUY**: purchase
        /// *   **RENEW**: renewal
        /// *   **UPGRADE**: upgrade
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
