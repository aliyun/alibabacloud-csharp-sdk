// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateMemberResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, a null value was returned.</description></item>
        /// <item><description>If the value of success was true, the authorization information was returned.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Member Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error code was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
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
        /// <item><description>If the value of success was false, an error message was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The status code returned. The value was fixed to 200. The status code 200 indicates that the request was successful.</para>
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
        /// <para>F989CA70-2925-5A94-92B7-20F5762B71C8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
