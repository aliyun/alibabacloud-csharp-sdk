// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetIndexMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The core data object of the response.</para>
        /// <para><b>pipelineCommercialType</b> (String): The edition of the knowledge base.</para>
        /// <list type="bullet">
        /// <item><description><para>standard: Standard Edition</para>
        /// </description></item>
        /// <item><description><para>enterprise: Ultimate Edition</para>
        /// </description></item>
        /// </list>
        /// <para><b>storageMonitorData</b> (Object): The storage monitoring data of the knowledge base.</para>
        /// <list type="bullet">
        /// <item><description><para>indexStorageLimit (Number): The index storage limit of the knowledge base, in GB.</para>
        /// </description></item>
        /// <item><description><para>indexStorageUsage (Number): The current index storage usage of the knowledge base, in GB.</para>
        /// </description></item>
        /// </list>
        /// <para><b>pipelineCommercialCu</b> (Integer): The number of RCU for the Ultimate Edition knowledge base. For example: 2.</para>
        /// <para><b>qpsMonitorData</b> (Object): The aggregated retrieval monitoring data for the knowledge base over the entire query period.</para>
        /// <list type="bullet">
        /// <item><description><para>peakQps (Integer): The peak QPS over the entire time period.</para>
        /// </description></item>
        /// <item><description><para>totalRequests (Integer): The total number of requests over the entire time period.</para>
        /// </description></item>
        /// <item><description><para>avgQpsOfActiveSeconds (Number): The average QPS during active seconds over the entire time period. Active seconds are seconds in which calls were made.</para>
        /// </description></item>
        /// <item><description><para>monitorData (Array): An array of detailed monitoring data broken down by time window. Each object in the array represents the performance statistics for a single time window.</para>
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>Sub-properties</para>
        /// </summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>successData (Object): The statistics for successful requests within this window.</para>
        /// </description></item>
        /// <item><description><para>limitData (Object): The statistics for rate-limited requests within this window.</para>
        /// </description></item>
        /// <item><description><para>failData (Object): The statistics for failed calls within this window.</para>
        /// </description></item>
        /// <item><description><para>peakQpsInWindowRange (Integer): The total peak QPS within this window (successful + rate-limited + failed).</para>
        /// </description></item>
        /// <item><description><para>totalRequests (Integer): The total number of requests within this window (successful + rate-limited + failed).</para>
        /// </description></item>
        /// <item><description><para>windowRange (Integer): The start time of the time window (UNIX timestamp in seconds).</para>
        /// </description></item>
        /// <item><description><para>windowRangeEnd (Integer): The end time of the time window (UNIX timestamp in seconds).</para>
        /// </description></item>
        /// <item><description><para>avgQpsOfActiveSeconds (Number): The average QPS during active seconds within this window.</para>
        /// </description></item>
        /// </list>
        /// <para><b>The successData, limitData, and failData objects have the same internal structure, as described below:</b></para>
        /// <list type="bullet">
        /// <item><description><para>peakQpsInWindowRange (Integer): The peak QPS for the corresponding status.</para>
        /// </description></item>
        /// <item><description><para>totalRequests (Integer): The total number of requests for the corresponding status.</para>
        /// </description></item>
        /// <item><description><para>avgQpsOfActiveSeconds (Number): The average QPS during active seconds for the corresponding status.</para>
        /// </description></item>
        /// </list>
        /// </details></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;code&quot;: &quot;Success&quot;,
        ///     &quot;status_code&quot;: 200,
        ///     &quot;data&quot;: {
        /// &quot;pipelineCommercialType&quot;: &quot;standard&quot;,       &quot;storageMonitorData&quot;: Object{...},
        ///         &quot;qpsMonitorData&quot;: Object{...}
        ///     },
        ///     &quot;success&quot;: true,
        ///     &quot;message&quot;: &quot;success&quot;,
        ///     &quot;request_id&quot;: &quot;65d34b79-b97e-478e-a0a3-xxx&quot;,
        ///     &quot;status&quot;: &quot;SUCCESS&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>778C0B3B-xxxx-5FC1-A947-36EDD13606AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
