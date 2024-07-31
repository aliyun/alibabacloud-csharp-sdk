// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartDIJobShrinkRequest : TeaModel {
        /// <summary>
        /// The task ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// Specifies whether to forcefully rerun all synchronization steps. If you do not configure this parameter, the system does not forcefully rerun the task.
        /// </summary>
        [NameInMap("ForceToRerun")]
        [Validation(Required=false)]
        public bool? ForceToRerun { get; set; }

        /// <summary>
        /// The settings for the start.
        /// </summary>
        [NameInMap("RealtimeStartSettings")]
        [Validation(Required=false)]
        public string RealtimeStartSettingsShrink { get; set; }

    }

}
