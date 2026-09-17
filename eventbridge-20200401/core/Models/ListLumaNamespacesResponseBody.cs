// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListLumaNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates a successful operation. If the operation fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of namespaces bound to the agent, including entries and pagination information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLumaNamespacesResponseBodyData Data { get; set; }
        public class ListLumaNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The effective page size for this request. If the Limit parameter is not specified, the server default value is used. If the specified value exceeds the upper limit, the value is adjusted to the maximum allowed value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            /// <summary>
            /// <para>The list of namespaces bound to the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Name&quot;:&quot;my_namespace&quot;}]</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<Namespace> Namespaces { get; set; }

            /// <summary>
            /// <para>The token for the next page. Pass this value as the NextToken parameter in the next request to retrieve the next page. An empty value indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of namespaces bound to the agent, regardless of the number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message. A value of Operation success is returned if the operation succeeds. A specific error description is returned if the operation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Use this ID for troubleshooting and when submitting a ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
