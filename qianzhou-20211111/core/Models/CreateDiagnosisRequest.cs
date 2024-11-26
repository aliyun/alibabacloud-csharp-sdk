// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class CreateDiagnosisRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("clusterID")]
        [Validation(Required=false)]
        public string ClusterID { get; set; }

        [NameInMap("diagnosisType")]
        [Validation(Required=false)]
        public string DiagnosisType { get; set; }

    }

}
