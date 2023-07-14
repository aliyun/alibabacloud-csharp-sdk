// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteScenarioRequest : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the business monitoring job. You can obtain the ID by calling the ListScenario operation.
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public long? ScenarioId { get; set; }

    }

}
