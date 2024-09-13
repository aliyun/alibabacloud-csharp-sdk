// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGsShrinkRequest : TeaModel {
        /// <summary>
        /// The AIC instance ID to be queried.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// The IDs of SDGs that you want to query. By default, all SDGs are queried.
        /// </summary>
        [NameInMap("SDGIds")]
        [Validation(Required=false)]
        public string SDGIdsShrink { get; set; }

    }

}
