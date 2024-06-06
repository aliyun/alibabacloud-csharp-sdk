// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetReductionProposalRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The type of the data quality evaluation. 1 is DQI and 2 is DQR.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataQualityEvaluationType")]
        [Validation(Required=false)]
        public int? DataQualityEvaluationType { get; set; }

        /// <summary>
        /// The product id.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// Product type: 1 indicates that the carbon footprint of the product is requested, and 5 indicates that the carbon footprint of the supply chain is requested.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public long? ProductType { get; set; }

    }

}
