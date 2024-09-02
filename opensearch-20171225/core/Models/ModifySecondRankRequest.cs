// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifySecondRankRequest : TeaModel {
        /// <summary>
        /// The request parameters.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SecondRank Body { get; set; }

        /// <summary>
        /// Specifies whether the request is a dry run.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
