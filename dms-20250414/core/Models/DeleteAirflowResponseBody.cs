// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DeleteAirflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_FOUND</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the deleted instance.</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public DeleteAirflowResponseBodyRoot Root { get; set; }
        public class DeleteAirflowResponseBodyRoot : TeaModel {
            /// <summary>
            /// <para>The details of the return value.</para>
            /// </summary>
            [NameInMap("Responses")]
            [Validation(Required=false)]
            public List<DeleteAirflowResponseBodyRootResponses> Responses { get; set; }
            public class DeleteAirflowResponseBodyRootResponses : TeaModel {
                /// <summary>
                /// <para>Indicates whether the request was successful. The following values are returned:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The request was successful.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The request failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>The UUID of the asset instance.</para>
                /// <remarks>
                /// <para>This result is not returned if no process exists under the asset.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>af-test****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. The following values are returned:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
