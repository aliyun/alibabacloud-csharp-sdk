// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyImageFixCycleConfigRequest : TeaModel {
        /// <summary>
        /// The cycle of the scheduled fix. Unit: day.
        /// </summary>
        [NameInMap("ImageFixCycle")]
        [Validation(Required=false)]
        public int? ImageFixCycle { get; set; }

        /// <summary>
        /// Specifies whether to enable the schedule image fix.
        /// 
        /// *   **on**: enable
        /// *   **off**: disable
        /// </summary>
        [NameInMap("ImageFixSwitch")]
        [Validation(Required=false)]
        public string ImageFixSwitch { get; set; }

        /// <summary>
        /// The range of the scheduled fix. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **type**: The type of the image. The value is fixed to repo.
        /// *   **target**: The content of the image. The value is in the format of Namespace/Image repository.
        /// </summary>
        [NameInMap("ImageFixTarget")]
        [Validation(Required=false)]
        public string ImageFixTarget { get; set; }

        /// <summary>
        /// The time range during which the image was modified. Unit: day.
        /// </summary>
        [NameInMap("ImageTimeRange")]
        [Validation(Required=false)]
        public int? ImageTimeRange { get; set; }

    }

}
