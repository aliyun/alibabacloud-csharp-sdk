// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class SetAllowIPRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=true)]
        public string NetworkType { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("AllowIP")]
        [Validation(Required=true)]
        public string AllowIP { get; set; }

        [NameInMap("Append")]
        [Validation(Required=false)]
        public bool? Append { get; set; }

    }

}
