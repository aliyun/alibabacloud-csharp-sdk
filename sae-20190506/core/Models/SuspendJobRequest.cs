// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class SuspendJobRequest : TeaModel {
        /// <summary>
        /// The ID of the job template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Specifies whether to suspend the job template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Suspend")]
        [Validation(Required=false)]
        public bool? Suspend { get; set; }

    }

}
