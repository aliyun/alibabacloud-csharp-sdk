// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectKneeKeypointXRayRequest : TeaModel {
        [NameInMap("ImageUrl")]
        [Validation(Required=true)]
        public string ImageUrl { get; set; }

        [NameInMap("DataFormat")]
        [Validation(Required=true)]
        public string DataFormat { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=true)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=true)]
        public string OrgName { get; set; }

        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
