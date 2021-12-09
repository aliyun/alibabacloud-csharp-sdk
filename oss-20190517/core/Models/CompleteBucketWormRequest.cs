// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CompleteBucketWormRequest : TeaModel {
        /// <summary>
        /// The ID of the retention policy
        /// </summary>
        [NameInMap("wormId")]
        [Validation(Required=false)]
        public string WormId { get; set; }

    }

}
