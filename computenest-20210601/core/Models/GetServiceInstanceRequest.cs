// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceInstanceRequest : TeaModel {
        /// <summary>
        /// The MarketInstance ID.
        /// </summary>
        [NameInMap("MarketInstanceId")]
        [Validation(Required=false)]
        public string MarketInstanceId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service instance ID.
        /// 
        /// >  You must specify either `ServiceInstanceId` or `MarketInstanceId`. Otherwise, the operation fails.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
