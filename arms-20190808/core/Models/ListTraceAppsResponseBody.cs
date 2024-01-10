// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListTraceAppsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned for the request. Valid values:
        /// 
        /// *   `2XX`: The request is successful.
        /// *   `3XX`: A redirection message is returned.
        /// *   `4XX`: The request is invalid.
        /// *   `5XX`: A server error occurs.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message returned if the request parameters are invalid.
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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   `true`: The call was successful.
        /// *   `false`: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The queried application monitoring tasks.
        /// </summary>
        [NameInMap("TraceApps")]
        [Validation(Required=false)]
        public List<ListTraceAppsResponseBodyTraceApps> TraceApps { get; set; }
        public class ListTraceAppsResponseBodyTraceApps : TeaModel {
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
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The time when the monitoring task was created. The value is a timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The tags of the application.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// The language.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

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
            /// The source of the application.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTraceAppsResponseBodyTraceAppsTags> Tags { get; set; }
            public class ListTraceAppsResponseBodyTraceAppsTags : TeaModel {
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
            /// The time when the monitoring task was updated. The value is a timestamp. Unit: milliseconds.
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

            /// <summary>
            /// The type of the workload.
            /// </summary>
            [NameInMap("WorkloadKind")]
            [Validation(Required=false)]
            public string WorkloadKind { get; set; }

            /// <summary>
            /// The name of the workload.
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

        }

    }

}
