// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class SubmitSparkJobRequest : TeaModel {
        [NameInMap("VcName")]
        [Validation(Required=true)]
        public string VcName { get; set; }

        [NameInMap("ConfigJson")]
        [Validation(Required=true)]
        public string ConfigJson { get; set; }

    }

}
