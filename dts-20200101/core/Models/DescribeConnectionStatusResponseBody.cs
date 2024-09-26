// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConnectionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The connectivity of DTS servers to the destination database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;connectDetail&quot;: [       {         &quot;testName&quot;: &quot;PolarDB_o JDBC Connect&quot;,         &quot;testSuccess&quot;: true       },       {         &quot;testName&quot;: &quot;Ping &quot;,         &quot;testSuccess&quot;: true       },       {         &quot;testName&quot;: &quot;Telnet &quot;,         &quot;testSuccess&quot;: true       }     ],     &quot;connectRes&quot;: true,     &quot;connectAdvice&quot;: &quot;&quot;   }</para>
        /// </summary>
        [NameInMap("DestinationConnectionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestinationConnectionStatus { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A47C784-70EF-4111-8677-369CAA00****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The connectivity of DTS servers to the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;connectDetail&quot;: [       {         &quot;testName&quot;: &quot;Oracle JDBC Connect&quot;,         &quot;testSuccess&quot;: true       },       {         &quot;testName&quot;: &quot;Ping &quot;,         &quot;testSuccess&quot;: false       },       {         &quot;testName&quot;: &quot;Telnet &quot;,         &quot;testSuccess&quot;: true       }     ],     &quot;connectRes&quot;: true,     &quot;connectAdvice&quot;: &quot;&quot;   }</para>
        /// </summary>
        [NameInMap("SourceConnectionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceConnectionStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
