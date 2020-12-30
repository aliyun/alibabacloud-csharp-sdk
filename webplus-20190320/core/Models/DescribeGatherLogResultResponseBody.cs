// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeGatherLogResultResponseBody : TeaModel {
        [NameInMap("GatherLogResult")]
        [Validation(Required=false)]
        public DescribeGatherLogResultResponseBodyGatherLogResult GatherLogResult { get; set; }
        public class DescribeGatherLogResultResponseBodyGatherLogResult : TeaModel {
            [NameInMap("LogPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }
            [NameInMap("Change")]
            [Validation(Required=false)]
            public DescribeGatherLogResultResponseBodyGatherLogResultChange Change { get; set; }
            public class DescribeGatherLogResultResponseBodyGatherLogResultChange : TeaModel {
                [NameInMap("ChangePaused")]
                [Validation(Required=false)]
                public bool? ChangePaused { get; set; }

                [NameInMap("ChangeDescription")]
                [Validation(Required=false)]
                public string ChangeDescription { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("ChangeTimedout")]
                [Validation(Required=false)]
                public bool? ChangeTimedout { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("ChangeMessage")]
                [Validation(Required=false)]
                public string ChangeMessage { get; set; }

                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("ChangeFinished")]
                [Validation(Required=false)]
                public bool? ChangeFinished { get; set; }

                [NameInMap("CreateUsername")]
                [Validation(Required=false)]
                public string CreateUsername { get; set; }

                [NameInMap("ChangeSucceeded")]
                [Validation(Required=false)]
                public bool? ChangeSucceeded { get; set; }

                [NameInMap("ChangeId")]
                [Validation(Required=false)]
                public string ChangeId { get; set; }

                [NameInMap("ChangeAborted")]
                [Validation(Required=false)]
                public bool? ChangeAborted { get; set; }

                [NameInMap("EnvId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }

                [NameInMap("ChangeName")]
                [Validation(Required=false)]
                public string ChangeName { get; set; }

            }
            [NameInMap("InstanceResults")]
            [Validation(Required=false)]
            public DescribeGatherLogResultResponseBodyGatherLogResultInstanceResults InstanceResults { get; set; }
            public class DescribeGatherLogResultResponseBodyGatherLogResultInstanceResults : TeaModel {
                [NameInMap("InstanceResult")]
                [Validation(Required=false)]
                public List<DescribeGatherLogResultResponseBodyGatherLogResultInstanceResultsInstanceResult> InstanceResult { get; set; }
                public class DescribeGatherLogResultResponseBodyGatherLogResultInstanceResultsInstanceResult : TeaModel {
                    [NameInMap("TaskMessage")]
                    [Validation(Required=false)]
                    public string TaskMessage { get; set; }

                    [NameInMap("StorageKey")]
                    [Validation(Required=false)]
                    public string StorageKey { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("TaskSucceeded")]
                    [Validation(Required=false)]
                    public bool? TaskSucceeded { get; set; }

                }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
