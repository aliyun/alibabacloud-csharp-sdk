// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLoggingRequest : TeaModel {
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<CreateLoggingRequestLoggingDetails> LoggingDetails { get; set; }
        public class CreateLoggingRequestLoggingDetails : TeaModel {
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
