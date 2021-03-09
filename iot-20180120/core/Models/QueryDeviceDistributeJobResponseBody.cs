// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDistributeJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceDistributeJobResponseBodyData Data { get; set; }
        public class QueryDeviceDistributeJobResponseBodyData : TeaModel {
            [NameInMap("SourceUid")]
            [Validation(Required=false)]
            public string SourceUid { get; set; }
            [NameInMap("TargetUid")]
            [Validation(Required=false)]
            public string TargetUid { get; set; }
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public int? Strategy { get; set; }
            [NameInMap("TargetInstanceConfigs")]
            [Validation(Required=false)]
            public QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigs TargetInstanceConfigs { get; set; }
            public class QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigs : TeaModel {
                [NameInMap("targetInstanceConfigs")]
                [Validation(Required=false)]
                public List<QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigsTargetInstanceConfigs> TargetInstanceConfigs { get; set; }
                public class QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigsTargetInstanceConfigs : TeaModel {
                    [NameInMap("TargetInstanceId")]
                    [Validation(Required=false)]
                    public string TargetInstanceId { get; set; }

                }

            }
        };

    }

}
