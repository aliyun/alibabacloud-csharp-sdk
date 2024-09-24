// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePolicyPriorUsedResponseBody : TeaModel {
        /// <summary>
        /// The lowest priority of existing access control policies.
        /// 
        /// >  The value -1 indicates the lowest priority.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public int? End { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The highest priority of existing access control policies.
        /// 
        /// >  The value 0 indicates the highest priority.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
