// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateUserAnalyzerRequest : TeaModel {
        /// <summary>
        /// The basic analyzer.
        /// </summary>
        [NameInMap("business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        /// <summary>
        /// The application ID of the custom analyzer.
        /// </summary>
        [NameInMap("businessAppGroupId")]
        [Validation(Required=false)]
        public string BusinessAppGroupId { get; set; }

        /// <summary>
        /// The basic analyzer type. Valid values: AUTO, MODEL, SYSTEM, and USER.
        /// </summary>
        [NameInMap("businessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The analyzer name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The engine type. Valid values: HA3 and ES.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Default value: false.
        /// 
        /// Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
