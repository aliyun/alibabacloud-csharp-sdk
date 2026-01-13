// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class DownloadApiCallDailyDetailCmd : TeaModel {
        [NameInMap("apiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
