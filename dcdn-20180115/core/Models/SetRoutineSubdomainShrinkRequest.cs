// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetRoutineSubdomainShrinkRequest : TeaModel {
        /// <summary>
        /// The parameters of the subdomain.
        /// 
        /// The parameters are in the following format:
        /// 
        ///     Subdomains: [
        ///         "subdomain-test"
        ///     ]
        /// </summary>
        [NameInMap("Subdomains")]
        [Validation(Required=false)]
        public string SubdomainsShrink { get; set; }

    }

}
