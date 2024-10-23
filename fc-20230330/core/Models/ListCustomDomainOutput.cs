// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListCustomDomainOutput : TeaModel {
        [NameInMap("customDomains")]
        [Validation(Required=false)]
        public List<CustomDomain> CustomDomains { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>next_domain_name</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
