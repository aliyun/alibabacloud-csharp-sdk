// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyConcernNecessityRequest : TeaModel {
        /// <summary>
        /// The priorities to fix the vulnerabilities. Valid values:
        /// 
        /// *   asap: high
        /// *   later: medium
        /// *   nntf: low
        /// </summary>
        [NameInMap("ConcernNecessity")]
        [Validation(Required=false)]
        public string ConcernNecessity { get; set; }

    }

}
