// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateSceneDefensePolicyRequest : TeaModel {
        /// <summary>
        /// The end time of the policy. This value is a UNIX timestamp. Units: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The name of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The start time of the policy. This value is a UNIX timestamp. Units: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The template of the policy. Valid values:
        /// 
        /// *   **promotion**: important activity
        /// *   **bypass**: all traffic forwarded
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
