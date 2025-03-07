// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLivePackageChannelCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ingest endpoint.</para>
        /// </summary>
        [NameInMap("IngestEndpoints")]
        [Validation(Required=false)]
        public List<UpdateLivePackageChannelCredentialsResponseBodyIngestEndpoints> IngestEndpoints { get; set; }
        public class UpdateLivePackageChannelCredentialsResponseBodyIngestEndpoints : TeaModel {
            /// <summary>
            /// <para>The ingest endpoint ID. <c>input1</c> indicates primary and <c>input2</c> indicates secondary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>input1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>examplePassword123</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The ingest endpoint URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/input1</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>771A1414-27BF-53E6-AB73-EFCB*****ACF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
