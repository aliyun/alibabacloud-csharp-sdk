// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListHasDiagnosisEmergencyoftaskRequest : TeaModel {
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("DgNodeId")]
        [Validation(Required=false)]
        public string DgNodeId { get; set; }

        [NameInMap("RequestBodyJsonStr")]
        [Validation(Required=false)]
        public string RequestBodyJsonStr { get; set; }

    }

}
