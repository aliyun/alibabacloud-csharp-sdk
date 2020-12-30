// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetSmartAGDpiAttributeResponseBody : TeaModel {
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

        [NameInMap("DpiMonitorStatus")]
        [Validation(Required=false)]
        public string DpiMonitorStatus { get; set; }

        [NameInMap("DpiStatus")]
        [Validation(Required=false)]
        public string DpiStatus { get; set; }

    }

}
