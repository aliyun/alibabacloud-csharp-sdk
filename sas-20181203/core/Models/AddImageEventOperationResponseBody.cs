// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageEventOperationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddImageEventOperationResponseBodyData Data { get; set; }
        public class AddImageEventOperationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The rule conditions. The value is in JSON format. Valid keys:</para>
            /// <list type="bullet">
            /// <item><description><b>condition</b>: The matching condition.</description></item>
            /// <item><description><b>type</b>: The matching type.</description></item>
            /// <item><description><b>value</b>: The matching value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;condition\&quot;: \&quot;MD5\&quot;, \&quot;type\&quot;: \&quot;equals\&quot;, \&quot;value\&quot;: \&quot;0083a31cc0083a31ccf7c10367a6e783e\&quot;}]</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public string Conditions { get; set; }

            /// <summary>
            /// <para>The alert metric keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PEM</para>
            /// </summary>
            [NameInMap("EventKey")]
            [Validation(Required=false)]
            public string EventKey { get; set; }

            /// <summary>
            /// <para>The alert metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PEM</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The Alarm Metric for alerting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sensitiveFile</b>: Sensitive file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sensitiveFile</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The primary key of the alert handling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443496</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The operation code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>whitelist</b>: Whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <para>The rule scope. The value is in JSON format. Valid keys:</para>
            /// <list type="bullet">
            /// <item><description><b>type</b>: The scope type.</description></item>
            /// <item><description><b>value</b>: The scope value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
            /// </summary>
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public string Scenarios { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C8487EF-50C2-54BB-8634-10F8C35D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The API call succeeded.</description></item>
        /// <item><description><b>false</b>: The API call failed.</description></item>
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
