// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineCanaryAreasResponseBody : TeaModel {
        [NameInMap("CanaryAreas")]
        [Validation(Required=false)]
        public List<string> CanaryAreas { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
