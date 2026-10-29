// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class RefreshResolveCacheShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of domain names to refresh.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string DomainsShrink { get; set; }

    }

}
