// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTraceAppByPageResponseBody : TeaModel {
        /// <summary>
        /// The information about the array object.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTraceAppByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchTraceAppByPageResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The information about the monitoring task.
            /// </summary>
            [NameInMap("TraceApps")]
            [Validation(Required=false)]
            public List<SearchTraceAppByPageResponseBodyPageBeanTraceApps> TraceApps { get; set; }
            public class SearchTraceAppByPageResponseBodyPageBeanTraceApps : TeaModel {
                /// <summary>
                /// The application ID.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The timestamp generated when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The aliases of the application.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// The process identifier (PID) of the application.
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the application is displayed in the Application Real-Time Monitoring Service (ARMS) console. Valid values:
                /// 
                /// *   `true`: yes
                /// *   `false`: no
                /// </summary>
                [NameInMap("Show")]
                [Validation(Required=false)]
                public bool? Show { get; set; }

                /// <summary>
                /// A list of tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<SearchTraceAppByPageResponseBodyPageBeanTraceAppsTags> Tags { get; set; }
                public class SearchTraceAppByPageResponseBodyPageBeanTraceAppsTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The type of the monitoring task. Valid values:
                /// 
                /// *   `TRACE`: Application Monitoring
                /// *   `RETCODE`: Browser Monitoring
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The timestamp generated when the task information was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
