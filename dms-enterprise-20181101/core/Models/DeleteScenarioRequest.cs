// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteScenarioRequest : TeaModel {
        /// <summary>
        /// Deletes a business scenario.
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public long? ScenarioId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
