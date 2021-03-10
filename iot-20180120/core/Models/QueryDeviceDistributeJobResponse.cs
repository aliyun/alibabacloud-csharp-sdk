// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDistributeJobResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceDistributeJobResponseData Data { get; set; }
        public class QueryDeviceDistributeJobResponseData : TeaModel {
            [NameInMap("SourceUid")]
            [Validation(Required=true)]
            public string SourceUid { get; set; }
            [NameInMap("TargetUid")]
            [Validation(Required=true)]
            public string TargetUid { get; set; }
            [NameInMap("SourceInstanceId")]
            [Validation(Required=true)]
            public string SourceInstanceId { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=true)]
            public string JobId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=true)]
            public int? Strategy { get; set; }
            [NameInMap("TargetInstanceConfigs")]
            [Validation(Required=true)]
            public QueryDeviceDistributeJobResponseDataTargetInstanceConfigs TargetInstanceConfigs { get; set; }
            public class QueryDeviceDistributeJobResponseDataTargetInstanceConfigs : TeaModel {
                [NameInMap("targetInstanceConfigs")]
                [Validation(Required=true)]
                public List<QueryDeviceDistributeJobResponseDataTargetInstanceConfigsTargetInstanceConfigs> TargetInstanceConfigs { get; set; }
                public class QueryDeviceDistributeJobResponseDataTargetInstanceConfigsTargetInstanceConfigs : TeaModel {
                    [NameInMap("TargetInstanceId")]
                    [Validation(Required=true)]
                    public string TargetInstanceId { get; set; }

                }

            }
        };

    }

}
