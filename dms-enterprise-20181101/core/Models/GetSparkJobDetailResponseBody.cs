// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSparkJobDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Details of the spark job
        /// </summary>
        [NameInMap("JobDetail")]
        [Validation(Required=false)]
        public GetSparkJobDetailResponseBodyJobDetail JobDetail { get; set; }
        public class GetSparkJobDetailResponseBodyJobDetail : TeaModel {
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("MainClass")]
            [Validation(Required=false)]
            public string MainClass { get; set; }
            [NameInMap("MainFile")]
            [Validation(Required=false)]
            public string MainFile { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
