// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetLogSampleRequest : TeaModel {
        [NameInMap("AppField")]
        [Validation(Required=false)]
        public string AppField { get; set; }

        [NameInMap("AppValue")]
        [Validation(Required=false)]
        public string AppValue { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        [NameInMap("LogField")]
        [Validation(Required=false)]
        public string LogField { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
