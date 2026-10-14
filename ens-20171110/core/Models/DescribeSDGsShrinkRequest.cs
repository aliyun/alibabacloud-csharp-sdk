// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of AIC instance IDs to query.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of SDG IDs to query.</para>
        /// </summary>
        [NameInMap("SDGIds")]
        [Validation(Required=false)]
        public string SDGIdsShrink { get; set; }

    }

}
