// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetInventoryListRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Type of emission
        /// 
        /// >  Valid values: footprint | emission. Meaning: footprint: all inventories are involved in the calculation; emission: only inventories with positive and zero emissions are involved in the calculation, and negative numbers are not involved in the calculation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("emissionType")]
        [Validation(Required=false)]
        public string EmissionType { get; set; }

        /// <summary>
        /// Group by
        /// 
        /// >  Valid values: resource | process | resourceType | processType. Meaning: resource: aggregation by inventory group, process: aggregation by operation group, resourceType: aggregation by inventory type, processType: aggregation by phase group
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// The type of the obtained environmental impact: gwp indicates the carbon footprint of climate change. 
        /// <props="intl">[For more information, see the environment impact category enumeration.](https://www.alibabacloud.com/help/en/energy-expert/developer-reference/enumerated-values-of-energy-expert#RhGn7)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("methodType")]
        [Validation(Required=false)]
        public string MethodType { get; set; }

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
