// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class ConversionDataRequest : TeaModel {
        [NameInMap("ReportTime")]
        [Validation(Required=false)]
        public long? ReportTime { get; set; }

        [NameInMap("ConversionRate")]
        [Validation(Required=false)]
        public string ConversionRate { get; set; }

    }

}
