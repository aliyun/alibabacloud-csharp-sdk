// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListPublishedServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the microservice list was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The list was obtained.</description></item>
        /// <item><description><b>false</b>: The list failed to be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The type of the published service.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPublishedServicesResponseBodyData> Data { get; set; }
        public class ListPublishedServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reserved parameter. This parameter does not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2a8a925-477a-4ed7-b825-d5e22500****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The subscription address of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Group2Ip")]
            [Validation(Required=false)]
            public string Group2Ip { get; set; }

            /// <summary>
            /// <para>The version of the published services.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<string> Groups { get; set; }

            /// <summary>
            /// <para>The name of the published service.</para>
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// <para>The returned error code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
            /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.nodejs.ItemService</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The service group that corresponds to the consumed service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the call was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the call was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the call failed.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the call fails, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the microservices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
