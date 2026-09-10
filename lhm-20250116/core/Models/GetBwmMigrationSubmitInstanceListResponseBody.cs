// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetBwmMigrationSubmitInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetBwmMigrationSubmitInstanceListResponseBodyData> Data { get; set; }
        public class GetBwmMigrationSubmitInstanceListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason for the conversion failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The conversion execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("gmtConvert")]
            [Validation(Required=false)]
            public string GmtConvert { get; set; }

            /// <summary>
            /// <para>The UUID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance-1</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The time when the source metadata was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("srcMetaGmtUpdate")]
            [Validation(Required=false)]
            public string SrcMetaGmtUpdate { get; set; }

            /// <summary>
            /// <para>The scheduling information of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source-info</para>
            /// </summary>
            [NameInMap("srcMetaInfo")]
            [Validation(Required=false)]
            public string SrcMetaInfo { get; set; }

            /// <summary>
            /// <para>The execution status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_START: Not started.</description></item>
            /// <item><description>READY: Pending execution.</description></item>
            /// <item><description>RUNNING: Running.</description></item>
            /// <item><description>ALL_SUCCESS: All succeeded.</description></item>
            /// <item><description>PARTIAL_SUCCESS: Partially succeeded.</description></item>
            /// <item><description>FAILURE: Failed.</description></item>
            /// <item><description>MANUAL: Manually uploaded.</description></item>
            /// </list>
            /// <para>If the status code cannot be recognized, the value defaults to NOT_START.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_START</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the result is empty.</para>
        /// </summary>
        [NameInMap("empty")]
        [Validation(Required=false)]
        public bool? Empty { get; set; }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether the result is not empty.</para>
        /// </summary>
        [NameInMap("notEmpty")]
        [Validation(Required=false)]
        public bool? NotEmpty { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, use errCode and errMessage to troubleshoot the issue.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
