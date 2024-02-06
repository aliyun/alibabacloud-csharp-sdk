// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketLifecycleRequest : TeaModel {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The ID of the rule to be queried. If this parameter is not specified, all rules are returned.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
