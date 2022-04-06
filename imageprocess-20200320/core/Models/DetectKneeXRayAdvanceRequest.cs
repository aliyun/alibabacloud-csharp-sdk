// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectKneeXRayAdvanceRequest : TeaModel {
        [NameInMap("UrlObject")]
        [Validation(Required=true)]
        public Stream UrlObject { get; set; }

        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

    }

}
