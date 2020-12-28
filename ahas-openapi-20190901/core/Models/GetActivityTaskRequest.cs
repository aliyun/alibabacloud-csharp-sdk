// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetActivityTaskRequest : TeaModel {
        [NameInMap("ExperimentTaskId")]
        [Validation(Required=false)]
        public string ExperimentTaskId { get; set; }

        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        [NameInMap("ActivityTaskId")]
        [Validation(Required=false)]
        public string ActivityTaskId { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
