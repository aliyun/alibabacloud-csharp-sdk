// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The job instance information if <c>success</c> is <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>An empty object if <c>success</c> is <c>false</c>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Job Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>An error code if <c>success</c> is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para>An empty string if <c>success</c> is <c>true</c>.</para>
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
        /// <item><description><para>An error message if <c>success</c> is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para>An empty string if <c>success</c> is <c>true</c>.</para>
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
        /// <para>The request ID.</para>
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

    }

}
