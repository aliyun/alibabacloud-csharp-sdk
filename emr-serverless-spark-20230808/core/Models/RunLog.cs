// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class RunLog : TeaModel {
        [NameInMap("driverStartup")]
        [Validation(Required=false)]
        public string DriverStartup { get; set; }

        [NameInMap("driverStdError")]
        [Validation(Required=false)]
        public string DriverStdError { get; set; }

        [NameInMap("driverStdOut")]
        [Validation(Required=false)]
        public string DriverStdOut { get; set; }

        [NameInMap("driverSyslog")]
        [Validation(Required=false)]
        public string DriverSyslog { get; set; }

    }

}
