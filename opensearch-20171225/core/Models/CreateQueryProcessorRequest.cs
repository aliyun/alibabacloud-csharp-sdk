// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateQueryProcessorRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public object Body { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
