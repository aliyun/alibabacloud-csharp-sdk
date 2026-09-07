// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryAppMetadataResponseBody : TeaModel {
        /// <summary>
        /// <para>The API call status.</para>
        /// <list type="bullet">
        /// <item><description><para>2xx: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>3xx: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para>4xx: A client-side error occurred.</para>
        /// </description></item>
        /// <item><description><para>5xx: A server-side error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;408d5533\&quot;: \&quot;SELECT * FROM user_base_info\&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51877BAC-330C-5845-BDFD-C7859AD33FB7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the query was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The query was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The query failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
