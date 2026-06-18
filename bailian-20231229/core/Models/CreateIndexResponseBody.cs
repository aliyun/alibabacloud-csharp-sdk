// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexResponseBody : TeaModel {
        /// <summary>
        /// <para>Error status code</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateIndexResponseBodyData Data { get; set; }
        public class CreateIndexResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the knowledge base, also known as \<c>IndexId\\</c>. This is the unique identifier of the created knowledge base.</para>
            /// <remarks>
            /// <para>Keep this value safe. It will be used for all subsequent API operations related to this knowledge base.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>jkurxhxxxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>Error message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A--2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned by the interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;200&quot;</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful</para>
        /// </description></item>
        /// <item><description><para>false: Failed</para>
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
