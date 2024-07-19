// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateSnapshotSettingRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("quartzRegex")]
        [Validation(Required=false)]
        public string QuartzRegex { get; set; }

    }

}
