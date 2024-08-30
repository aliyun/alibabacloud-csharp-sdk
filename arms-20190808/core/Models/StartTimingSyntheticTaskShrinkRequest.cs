// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class StartTimingSyntheticTaskShrinkRequest : TeaModel {
        /// <summary>
        /// The region ID. Default value: cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The task IDs.
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIdsShrink { get; set; }

    }

}
