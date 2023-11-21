// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CompletePhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among different requests.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** of each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether the construction is completed. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("FinishWork")]
        [Validation(Required=false)]
        public bool? FinishWork { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The circuit code provided by the connectivity provider.
        /// </summary>
        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        /// <summary>
        /// The label of the cable in the data center.
        /// </summary>
        [NameInMap("LineLabel")]
        [Validation(Required=false)]
        public string LineLabel { get; set; }

        /// <summary>
        /// The contact information about line O\&M.
        /// </summary>
        [NameInMap("LineSPContactInfo")]
        [Validation(Required=false)]
        public string LineSPContactInfo { get; set; }

        /// <summary>
        /// The ISP. Valid values:
        /// 
        /// *   **China Telecom**
        /// *   **China Unicom**
        /// *   **China Mobile**
        /// *   **Other ISPs in China**
        /// </summary>
        [NameInMap("LineServiceProvider")]
        [Validation(Required=false)]
        public string LineServiceProvider { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the Express Connect circuit.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
