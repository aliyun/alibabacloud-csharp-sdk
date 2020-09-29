// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectSkinDiseaseRequest : TeaModel {
        [NameInMap("Url")]
        [Validation(Required=true)]
        public string Url { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=true)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=true)]
        public string OrgName { get; set; }

    }

}
