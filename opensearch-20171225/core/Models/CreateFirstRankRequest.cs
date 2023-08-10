// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFirstRankRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public FirstRank Body { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
