// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class AddEndPointRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=true)]
        public string NetworkType { get; set; }

        [NameInMap("VpcID")]
        [Validation(Required=true)]
        public string VpcID { get; set; }

        [NameInMap("Vswitch")]
        [Validation(Required=true)]
        public string Vswitch { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=true)]
        public string Zone { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
