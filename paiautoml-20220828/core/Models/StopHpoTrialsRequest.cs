// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class StopHpoTrialsRequest : TeaModel {
        /// <summary>
        /// Trial Ids to be stopped.
        /// </summary>
        [NameInMap("TrialIds")]
        [Validation(Required=false)]
        public List<string> TrialIds { get; set; }

    }

}
