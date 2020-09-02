// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionSetupOrderRequest : TeaModel {
        /// <summary>
        /// description: The ID of the region where the leased line is deployed. You can get the region ID by calling the DescribeRegions API.; 
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// description: The ID of the access point.; 
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=true)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// description: The service provider that provides the leased line. Valid values:* CT: China Telecom* CU: China Unicom* CM: China Mobile* CO: Other Chinese service providers* Equinix: Equinix* Other: Other service providers outside Mainland China; 
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=true)]
        public string LineOperator { get; set; }

        /// <summary>
        /// description: Optional. The type of the leased line connection port. Valid values:* **100Base-T**: 100M electrical ports* **1000Base-T **(default value): Gigabit electrical ports* **1000Base-LX**: 1000M single-mode optical ports (10 km)* **10GBase-T**: 10GE electrical ports* **10GBase-LR**: 10GE single-mode optical ports (10km) ; 
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// description: The ID of the redundant physical connection. Its status must be **Allocated**,**Confirmed**or** Enabled**. ; 
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// description: Optional. Indicates whether to pay the fee automatically.Valid values: **true | false**; 
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// description: Optional. The token used for client authentication.; 
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
