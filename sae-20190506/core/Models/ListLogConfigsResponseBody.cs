// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListLogConfigsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the logging configurations of an application were obtained. Valid values:
        /// 
        /// *   **true**: indicates that the configurations were obtained.
        /// *   **false**: indicates that the configurations could not be obtained.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of logging configurations.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLogConfigsResponseBodyData Data { get; set; }
        public class ListLogConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The name of the Log Service configuration.
            /// </summary>
            [NameInMap("LogConfigs")]
            [Validation(Required=false)]
            public List<ListLogConfigsResponseBodyDataLogConfigs> LogConfigs { get; set; }
            public class ListLogConfigsResponseBodyDataLogConfigs : TeaModel {
                /// <summary>
                /// The path of logs.
                /// </summary>
                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                /// <summary>
                /// The storage type of logs.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The name of the Logstore in Log Service.
                /// </summary>
                [NameInMap("LogDir")]
                [Validation(Required=false)]
                public string LogDir { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// The number of the returned page.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The time when the configuration was created.
                /// </summary>
                [NameInMap("SlsLogStore")]
                [Validation(Required=false)]
                public string SlsLogStore { get; set; }

                /// <summary>
                /// The type of the log. Set this value to **file_log**.
                /// </summary>
                [NameInMap("SlsProject")]
                [Validation(Required=false)]
                public string SlsProject { get; set; }

                /// <summary>
                /// The ID of the Log Service project.
                /// </summary>
                [NameInMap("StoreType")]
                [Validation(Required=false)]
                public string StoreType { get; set; }

            }

            /// <summary>
            /// The error code.
            /// 
            /// *   The **ErrorCode** parameter is not returned when the request succeeds.
            /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error code is returned when the request fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The logging configurations.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
