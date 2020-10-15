// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportMeasurementDataRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=true)]
        public string StartDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=true)]
        public string EndDate { get; set; }

    }

}
