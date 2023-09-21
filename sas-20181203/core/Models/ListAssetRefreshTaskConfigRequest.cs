// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetRefreshTaskConfigRequest : TeaModel {
        [NameInMap("RefreshConfigType")]
        [Validation(Required=false)]
        public int? RefreshConfigType { get; set; }

        /// <summary>
        /// The region where the Security Center instance is deployed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public long? TargetId { get; set; }

    }

}
