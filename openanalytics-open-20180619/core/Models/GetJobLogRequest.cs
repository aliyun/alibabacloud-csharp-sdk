// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetJobLogRequest : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=true)]
        public string JobId { get; set; }

        [NameInMap("VcName")]
        [Validation(Required=true)]
        public string VcName { get; set; }

    }

}
