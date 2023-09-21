// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateVulAutoRepairConfigRequest : TeaModel {
        /// <summary>
        /// The reason why the vulnerability can be automatically fixed.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values: -**cve**: Linux software vulnerability -**sys**: Windows system vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The vulnerabilities that can be automatically fixed.
        /// </summary>
        [NameInMap("VulAutoRepairConfigList")]
        [Validation(Required=false)]
        public List<CreateVulAutoRepairConfigRequestVulAutoRepairConfigList> VulAutoRepairConfigList { get; set; }
        public class CreateVulAutoRepairConfigRequestVulAutoRepairConfigList : TeaModel {
            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
