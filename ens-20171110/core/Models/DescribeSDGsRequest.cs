// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGsRequest : TeaModel {
        /// <summary>
        /// <para>The list of AIC instance IDs to query.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The list of SDG IDs to query.</para>
        /// </summary>
        [NameInMap("SDGIds")]
        [Validation(Required=false)]
        public List<string> SDGIds { get; set; }

    }

}
