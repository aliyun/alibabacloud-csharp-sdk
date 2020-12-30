// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateSmartAccessGatewayRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("MaxBandWidth")]
        [Validation(Required=false)]
        public int? MaxBandWidth { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("HardWareSpec")]
        [Validation(Required=false)]
        public string HardWareSpec { get; set; }

        [NameInMap("ReceiverCountry")]
        [Validation(Required=false)]
        public string ReceiverCountry { get; set; }

        [NameInMap("ReceiverState")]
        [Validation(Required=false)]
        public string ReceiverState { get; set; }

        [NameInMap("ReceiverCity")]
        [Validation(Required=false)]
        public string ReceiverCity { get; set; }

        [NameInMap("ReceiverDistrict")]
        [Validation(Required=false)]
        public string ReceiverDistrict { get; set; }

        [NameInMap("ReceiverTown")]
        [Validation(Required=false)]
        public string ReceiverTown { get; set; }

        [NameInMap("ReceiverZip")]
        [Validation(Required=false)]
        public string ReceiverZip { get; set; }

        [NameInMap("ReceiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

        [NameInMap("ReceiverMobile")]
        [Validation(Required=false)]
        public string ReceiverMobile { get; set; }

        [NameInMap("ReceiverName")]
        [Validation(Required=false)]
        public string ReceiverName { get; set; }

        [NameInMap("ReceiverEmail")]
        [Validation(Required=false)]
        public string ReceiverEmail { get; set; }

        [NameInMap("BuyerMessage")]
        [Validation(Required=false)]
        public string BuyerMessage { get; set; }

        [NameInMap("ReceiverAddress")]
        [Validation(Required=false)]
        public string ReceiverAddress { get; set; }

        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("DataPlan")]
        [Validation(Required=false)]
        public long? DataPlan { get; set; }

        [NameInMap("AlreadyHaveSag")]
        [Validation(Required=false)]
        public bool? AlreadyHaveSag { get; set; }

    }

}
