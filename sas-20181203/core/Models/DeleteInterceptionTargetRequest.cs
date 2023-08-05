// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteInterceptionTargetRequest : TeaModel {
        /// <summary>
        /// The IDs of the network objects that you want to remove. You can call the [ListInterceptionTargetPage](~~ListInterceptionTargetPage~~) operation to query the IDs of the network objects.
        /// </summary>
        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public string TargetIds { get; set; }

    }

}
