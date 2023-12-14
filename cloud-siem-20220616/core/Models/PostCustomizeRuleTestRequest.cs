// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleTestRequest : TeaModel {
        /// <summary>
        /// The ID of the rule.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The simulation data for the testing. This parameter is available only when TestType is set to simulate.
        /// </summary>
        [NameInMap("SimulatedData")]
        [Validation(Required=false)]
        public string SimulatedData { get; set; }

        /// <summary>
        /// The testing type. Valid values:
        /// 
        /// *   simulate: simulation data test
        /// *   business: business data test
        /// </summary>
        [NameInMap("TestType")]
        [Validation(Required=false)]
        public string TestType { get; set; }

    }

}
