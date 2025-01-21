// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLivePackageChannelCredentialsResponseBody : TeaModel {
        [NameInMap("IngestEndpoints")]
        [Validation(Required=false)]
        public List<UpdateLivePackageChannelCredentialsResponseBodyIngestEndpoints> IngestEndpoints { get; set; }
        public class UpdateLivePackageChannelCredentialsResponseBodyIngestEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>input1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>examplePassword123</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/input1</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
