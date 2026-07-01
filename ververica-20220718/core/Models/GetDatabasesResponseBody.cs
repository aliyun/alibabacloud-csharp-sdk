// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of databases. This parameter is returned only if the request is successful. If the request fails, this parameter is empty.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Database> Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If \<c>success\\</c> is \<c>false\\</c>, an error code is returned.</para>
        /// </description></item>
        /// <item><description><para>If \<c>success\\</c> is \<c>true\\</c>, this parameter is empty.</para>
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
        /// <item><description><para>If \<c>success\\</c> is \<c>false\\</c>, an error message is returned.</para>
        /// </description></item>
        /// <item><description><para>If \<c>success\\</c> is \<c>true\\</c>, this parameter is empty.</para>
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
        /// <para>The HTTP status code. A value of 200 is always returned. To determine whether the request was successful, check the value of the \<c>success\\</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
