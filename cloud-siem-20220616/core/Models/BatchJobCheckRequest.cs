// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class BatchJobCheckRequest : TeaModel {
        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The id of task.
        /// </summary>
        [NameInMap("SubmitId")]
        [Validation(Required=false)]
        public string SubmitId { get; set; }

    }

}
