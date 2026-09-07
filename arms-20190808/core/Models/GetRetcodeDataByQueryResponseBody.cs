// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeDataByQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2XX: The request was successful.</description></item>
        /// <item><description>3XX: A redirection message was returned.</description></item>
        /// <item><description>4XX: The request was invalid.</description></item>
        /// <item><description>5XX: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Browser Monitoring data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;total&quot;: 1,
        ///     &quot;auth&quot;: false,
        ///     &quot;pageSize&quot;: 20,
        ///     &quot;completed&quot;: true,
        ///     &quot;page&quot;: 1,
        ///     &quot;items&quot;: [
        ///       {
        ///         &quot;date&quot;: &quot;1701820800000&quot;,
        ///         &quot;<b>time</b>&quot;: 1701410567,
        ///         &quot;uv&quot;: &quot;64&quot;,
        ///         &quot;<b>source</b>&quot;: &quot;&quot;,
        ///         &quot;pv&quot;: &quot;890&quot;
        ///       }
        ///     ]
        ///     }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error message returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A0CEDF1-06FE-44AC-8E21-21A5BE65****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
