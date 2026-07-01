// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the access denial.</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>When \<c>success\\</c> is \<c>true\\</c>, the created instance information is returned.</para>
        /// </description></item>
        /// <item><description><para>Returns an empty value if \<c>success\\</c> is false.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Job Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If success is false, the call returns a business error code.If success is true, the call returns business data. The following table describes the data format.If success is true, the call returns business data. The following table describes the data format.</para>
        /// </description></item>
        /// <item><description><para>When success is true, an empty value is returned.</para>
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
        /// <item><description><para>If success is false, a business error message is returned.</para>
        /// </description></item>
        /// <item><description><para>When \<c>success\\</c> is true, an empty value is returned.</para>
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
        /// <para>Fixed value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the service request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
