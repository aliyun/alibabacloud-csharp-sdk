// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeNodePoolVulsRequest : TeaModel {
        /// <summary>
        /// The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:
        /// 
        /// *   `asap`: high
        /// *   `later`: medium
        /// *   `nntf`: low
        /// </summary>
        [NameInMap("necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

    }

}
