// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentTaskModelUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The summary data of model usage for DataAgent analysis tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataAgentTaskModelUsageResponseBodyData Data { get; set; }
        public class GetDataAgentTaskModelUsageResponseBodyData : TeaModel {
            [NameInMap("AccelerationRatio")]
            [Validation(Required=false)]
            public double? AccelerationRatio { get; set; }

            [NameInMap("RateLimitedSessionCount")]
            [Validation(Required=false)]
            public long? RateLimitedSessionCount { get; set; }

            [NameInMap("TotalLlmWaitDuration")]
            [Validation(Required=false)]
            public double? TotalLlmWaitDuration { get; set; }

            [NameInMap("TotalSessionCount")]
            [Validation(Required=false)]
            public long? TotalSessionCount { get; set; }

            /// <summary>
            /// <para>The peak TPM (tokens per minute) within the query time range, which is the maximum number of tokens consumed per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42000</para>
            /// </summary>
            [NameInMap("peakTpm")]
            [Validation(Required=false)]
            public long? PeakTpm { get; set; }

            /// <summary>
            /// <para>The total number of model calls within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("totalCallCount")]
            [Validation(Required=false)]
            public long? TotalCallCount { get; set; }

            /// <summary>
            /// <para>The total number of tokens consumed within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3560000</para>
            /// </summary>
            [NameInMap("totalTokenConsumed")]
            [Validation(Required=false)]
            public long? TotalTokenConsumed { get; set; }

            /// <summary>
            /// <para>The number of models used within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("usedModels")]
            [Validation(Required=false)]
            public long? UsedModels { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DMS-DA-40411</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-***695C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
