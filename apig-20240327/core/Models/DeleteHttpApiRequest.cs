// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeleteHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run. If set to true, all synchronous validations identical to an actual deletion are executed (including admission checks such as whether a published API cannot be deleted), but the API is not deleted, no associated configurations are cleaned up, and no side effects are produced. If this parameter is not specified or is set to false, the behavior is the same as the existing version.</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
