// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckInstanceResultRequest : TeaModel {
        /// <summary>
        /// The ID of the check item.
        /// 
        /// > You can call the [ListCheckResult](~~ListCheckResult~~) operation to query the IDs of check items.
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// The instance IDs of the assets on which risks are detected based on the check item.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

    }

}
