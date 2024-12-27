// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class SearchTracesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the returned page.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTracesResponseBodyPageBean PageBean { get; set; }
        public class SearchTracesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The information about the traces that are returned.</para>
            /// </summary>
            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public SearchTracesResponseBodyPageBeanTraceInfos TraceInfos { get; set; }
            public class SearchTracesResponseBodyPageBeanTraceInfos : TeaModel {
                [NameInMap("TraceInfo")]
                [Validation(Required=false)]
                public List<SearchTracesResponseBodyPageBeanTraceInfosTraceInfo> TraceInfo { get; set; }
                public class SearchTracesResponseBodyPageBeanTraceInfosTraceInfo : TeaModel {
                    /// <summary>
                    /// <para>The execution duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <para>The span name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/api</para>
                    /// </summary>
                    [NameInMap("OperationName")]
                    [Validation(Required=false)]
                    public string OperationName { get; set; }

                    /// <summary>
                    /// <para>The IP address or name of the server on which the span is running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.163.XXX.XXX</para>
                    /// </summary>
                    [NameInMap("ServiceIp")]
                    [Validation(Required=false)]
                    public string ServiceIp { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service1</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    [NameInMap("StatusCode")]
                    [Validation(Required=false)]
                    public long? StatusCode { get; set; }

                    /// <summary>
                    /// <para>The tag information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;env&quot;:&quot;dev&quot;}</para>
                    /// </summary>
                    [NameInMap("TagMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> TagMap { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the span was generated. Unit: millisecond.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1575561600000000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The trace ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1c6881aab84191a4</para>
                    /// </summary>
                    [NameInMap("TraceID")]
                    [Validation(Required=false)]
                    public string TraceID { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
