// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetMachineGroupResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DefaultDriver")]
        [Validation(Required=false)]
        public string DefaultDriver { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("EcsType")]
        [Validation(Required=false)]
        public string EcsType { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("GmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("GmtStarted")]
        [Validation(Required=false)]
        public string GmtStarted { get; set; }

        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        [NameInMap("OrderID")]
        [Validation(Required=false)]
        public string OrderID { get; set; }

        [NameInMap("OrderInstanceId")]
        [Validation(Required=false)]
        public string OrderInstanceId { get; set; }

        [NameInMap("PAIResourceID")]
        [Validation(Required=false)]
        public string PAIResourceID { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupportedDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedDrivers { get; set; }

    }

}
