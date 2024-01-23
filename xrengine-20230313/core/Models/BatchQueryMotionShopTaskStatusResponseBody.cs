// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class BatchQueryMotionShopTaskStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchQueryMotionShopTaskStatusResponseBodyData Data { get; set; }
        public class BatchQueryMotionShopTaskStatusResponseBodyData : TeaModel {
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<BatchQueryMotionShopTaskStatusResponseBodyDataTasks> Tasks { get; set; }
            public class BatchQueryMotionShopTaskStatusResponseBodyDataTasks : TeaModel {
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public BatchQueryMotionShopTaskStatusResponseBodyDataTasksResult Result { get; set; }
                public class BatchQueryMotionShopTaskStatusResponseBodyDataTasksResult : TeaModel {
                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("ShareUrl")]
                    [Validation(Required=false)]
                    public string ShareUrl { get; set; }

                    [NameInMap("VideoUrl")]
                    [Validation(Required=false)]
                    public string VideoUrl { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
