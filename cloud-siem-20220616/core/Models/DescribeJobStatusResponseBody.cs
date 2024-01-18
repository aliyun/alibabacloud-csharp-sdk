// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeJobStatusResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
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
            /// The list of failed task.
            /// </summary>
            [NameInMap("ErrTaskList")]
            [Validation(Required=false)]
            public List<DescribeJobStatusResponseBodyDataErrTaskList> ErrTaskList { get; set; }
            public class DescribeJobStatusResponseBodyDataErrTaskList : TeaModel {
                /// <summary>
                /// The list of product.
                /// </summary>
                [NameInMap("ProductList")]
                [Validation(Required=false)]
                public List<DescribeJobStatusResponseBodyDataErrTaskListProductList> ProductList { get; set; }
                public class DescribeJobStatusResponseBodyDataErrTaskListProductList : TeaModel {
                    /// <summary>
                    /// The list of log.
                    /// </summary>
                    [NameInMap("LogList")]
                    [Validation(Required=false)]
                    public List<DescribeJobStatusResponseBodyDataErrTaskListProductListLogList> LogList { get; set; }
                    public class DescribeJobStatusResponseBodyDataErrTaskListProductListLogList : TeaModel {
                        /// <summary>
                        /// The error code.
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// The log code.
                        /// </summary>
                        [NameInMap("LogCode")]
                        [Validation(Required=false)]
                        public string LogCode { get; set; }

                        /// <summary>
                        /// The pattern of SLS logstore name.
                        /// </summary>
                        [NameInMap("LogStoreNamePattern")]
                        [Validation(Required=false)]
                        public string LogStoreNamePattern { get; set; }

                        /// <summary>
                        /// The code of product.
                        /// </summary>
                        [NameInMap("ProductCode")]
                        [Validation(Required=false)]
                        public string ProductCode { get; set; }

                        /// <summary>
                        /// The pattern of SLS project name.
                        /// </summary>
                        [NameInMap("ProjectNamePattern")]
                        [Validation(Required=false)]
                        public string ProjectNamePattern { get; set; }

                        /// <summary>
                        /// The ID of the region in which the instance resides.
                        /// </summary>
                        [NameInMap("RegionCode")]
                        [Validation(Required=false)]
                        public string RegionCode { get; set; }

                    }

                    /// <summary>
                    /// The code of product.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                }

                /// <summary>
                /// The account id of aliyun.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            /// <summary>
            /// The number of failed tasks.
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// The number of scan tasks that are complete.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// The ID of the folder.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// The number of existing tasks that are created to add logs within the data source.
            /// </summary>
            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

            /// <summary>
            /// The status of submitted task.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The returned message.
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
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
