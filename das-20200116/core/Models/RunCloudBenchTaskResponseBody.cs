// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class RunCloudBenchTaskResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information, including the error codes and the number of returned entries.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunCloudBenchTaskResponseBodyData Data { get; set; }
        public class RunCloudBenchTaskResponseBodyData : TeaModel {
            [NameInMap("PreCheckItem")]
            [Validation(Required=false)]
            public List<RunCloudBenchTaskResponseBodyDataPreCheckItem> PreCheckItem { get; set; }
            public class RunCloudBenchTaskResponseBodyDataPreCheckItem : TeaModel {
                /// <summary>
                /// The HTTP status code returned.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// The detailed information of the check item.
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public string Details { get; set; }

                /// <summary>
                /// The returned message.
                /// 
                /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The name of the check item. Valid values:
                /// 
                /// * **SqlArchiveStatusChecker**: checks whether SQL Explorer is available.
                /// * **BenchClientEnvChecker**: checks whether the runtime environment for programs on the stress testing client is available.
                /// * **SpecChecker**: checks whether the destination instance type and the instance type of the stress testing client support this API operation.
                /// * **SourceInstanceChecker**: checks whether the account of the source instance is available and whether the source instance is connected to the destination instance.
                /// * **BenchTargetChecker**: checks whether the account of the destination instance is available and whether the source instance is connected to the destination instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The sequence number of the check item. Valid values: **0** to **10**.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The status of the task. Valid values:
                /// 
                /// *   **SUCCESS**: The task is successful.
                /// *   **IGNORED**: The task is ignored.
                /// *   **RUNNING**: The task is running.
                /// *   **EXCEPTION**: An error occurred.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
