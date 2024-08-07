// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeJobStatusResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. If the request is successful, 200 is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobStatusResponseBodyData Data { get; set; }
        public class DescribeJobStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the task configuration.
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// The list of failed tasks. The value contains the Alibaba Cloud account and service code of each failed task.
            /// </summary>
            [NameInMap("ErrTaskList")]
            [Validation(Required=false)]
            public List<DescribeJobStatusResponseBodyDataErrTaskList> ErrTaskList { get; set; }
            public class DescribeJobStatusResponseBodyDataErrTaskList : TeaModel {
                /// <summary>
                /// The list of services in failed tasks.
                /// </summary>
                [NameInMap("ProductList")]
                [Validation(Required=false)]
                public List<DescribeJobStatusResponseBodyDataErrTaskListProductList> ProductList { get; set; }
                public class DescribeJobStatusResponseBodyDataErrTaskListProductList : TeaModel {
                    /// <summary>
                    /// The list of logs that fail to be collected.
                    /// </summary>
                    [NameInMap("LogList")]
                    [Validation(Required=false)]
                    public List<DescribeJobStatusResponseBodyDataErrTaskListProductListLogList> LogList { get; set; }
                    public class DescribeJobStatusResponseBodyDataErrTaskListProductListLogList : TeaModel {
                        /// <summary>
                        /// The reason for the failure.
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// The code of the logs.
                        /// </summary>
                        [NameInMap("LogCode")]
                        [Validation(Required=false)]
                        public string LogCode { get; set; }

                        /// <summary>
                        /// The pattern for the name of the Simple Log Service Logstore from which logs are collected.
                        /// </summary>
                        [NameInMap("LogStoreNamePattern")]
                        [Validation(Required=false)]
                        public string LogStoreNamePattern { get; set; }

                        /// <summary>
                        /// The code of the service.
                        /// </summary>
                        [NameInMap("ProductCode")]
                        [Validation(Required=false)]
                        public string ProductCode { get; set; }

                        /// <summary>
                        /// The pattern for the name of the Simple Log Service project from which logs are collected.
                        /// </summary>
                        [NameInMap("ProjectNamePattern")]
                        [Validation(Required=false)]
                        public string ProjectNamePattern { get; set; }

                        /// <summary>
                        /// The ID of the region.
                        /// </summary>
                        [NameInMap("RegionCode")]
                        [Validation(Required=false)]
                        public string RegionCode { get; set; }

                    }

                    /// <summary>
                    /// The code of the service.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                }

                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            /// <summary>
            /// The total number of tasks that fail.
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// The total number of tasks that are complete.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// The ID of the resource directory folder.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// The total number of collection tasks that are created.
            /// </summary>
            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

            /// <summary>
            /// The status of the submitted task.
            /// 
            /// Valid values:
            /// 
            /// *   submit
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   finish
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// The error code. If the request is successful, the parameter is empty. If the request fails, an error code is returned.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message. If the request is successful, the parameter is empty. If the request fails, the reason for the failure is returned.
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
        public bool? Success { get; set; }

    }

}
