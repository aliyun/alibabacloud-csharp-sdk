/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeFileModerationResultRequest : TeaModel {
        /// <summary>
        /// The type of the moderation service.
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// The parameters required by the moderation service. The value is a JSON string.
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
