// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTracesByPageRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("ExclusionFilters")]
        [Validation(Required=false)]
        public List<SearchTracesByPageRequestExclusionFilters> ExclusionFilters { get; set; }
        public class SearchTracesByPageRequestExclusionFilters : TeaModel {
            /// <summary>
            /// The key that is used to filter the query results.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the key that is used to filter the query results.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 是否过滤错误的调用链。
        /// - `true`：过滤
        /// - `false`（默认）：不过滤
        /// </summary>
        [NameInMap("IsError")]
        [Validation(Required=false)]
        public bool? IsError { get; set; }

        /// <summary>
        /// The minimum amount of time consumed by traces. Unit: milliseconds.
        /// </summary>
        [NameInMap("MinDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// The name of the traced span.
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The application ID.
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
        /// Specifies whether to sort the query results in chronological order or reverse chronological order. Default value: `false`.
        /// 
        /// *   `true`: sorts the query results in reverse chronological order.
        /// *   `false`: sorts the query results in chronological order.
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// The IP address of the host where the application resides.
        /// </summary>
        [NameInMap("ServiceIp")]
        [Validation(Required=false)]
        public string ServiceIp { get; set; }

        /// <summary>
        /// The name of the application.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<SearchTracesByPageRequestTags> Tags { get; set; }
        public class SearchTracesByPageRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag. The following system preset fields are provided:
            /// 
            /// *   traceId: the ID of the trace.
            /// *   serverApp: the name of the server application.
            /// *   clientApp: the name of the client application.
            /// *   service: the name of the operation.
            /// *   rpc: the type of the call.
            /// *   msOfSpan: the duration exceeds a specific value.
            /// *   clientIp: the IP address of the client.
            /// *   serverIp: the IP address of the server.
            /// *   isError: specifies whether the call is abnormal.
            /// *   hasTprof: contains only thread profiling.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
