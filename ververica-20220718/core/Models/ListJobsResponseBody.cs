// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>An array of job instances for a successful request (when <c>success</c> is <c>true</c>).</para>
        /// </description></item>
        /// <item><description><para>An empty array for a failed request (when <c>success</c> is <c>false</c>).</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Job> Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The error code for a failed request (when <c>success</c> is <c>false</c>).</para>
        /// </description></item>
        /// <item><description><para>An empty string if the request is successful (when <c>success</c> is <c>true</c>).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The error message for a failed request (when <c>success</c> is <c>false</c>).</para>
        /// </description></item>
        /// <item><description><para>An empty string if the request is successful (when <c>success</c> is <c>true</c>).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>A fixed value of 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
