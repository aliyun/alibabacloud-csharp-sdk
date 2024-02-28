// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteVulAutoRepairConfigRequest : TeaModel {
        /// <summary>
        /// The alias of the vulnerability.
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The configuration ID of the vulnerability. You can call the [ListVulAutoRepairConfig](~~ListVulAutoRepairConfig~~) operation to query the configuration IDs of the vulnerability.
        /// </summary>
        [NameInMap("ConfigIdList")]
        [Validation(Required=false)]
        public List<long?> ConfigIdList { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
