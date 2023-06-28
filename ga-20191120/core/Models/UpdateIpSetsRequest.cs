// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateIpSetsRequest : TeaModel {
        /// <summary>
        /// The acceleration regions.
        /// </summary>
        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<UpdateIpSetsRequestIpSets> IpSets { get; set; }
        public class UpdateIpSetsRequestIpSets : TeaModel {
            /// <summary>
            /// The new bandwidth of the acceleration region. Unit: Mbit/s.
            /// 
            /// You can specify the bandwidth for up to 100 acceleration regions.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The ID of the acceleration region that you want to modify.
            /// 
            /// You can specify the IDs of up to 100 acceleration regions.
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

        }

        /// <summary>
        /// The region ID of the Global Accelerator (GA) instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
