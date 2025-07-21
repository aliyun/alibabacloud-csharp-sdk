// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerResponseBodyData Data { get; set; }
        public class GetConsumerResponseBodyData : TeaModel {
            [NameInMap("akSkIdentityConfigs")]
            [Validation(Required=false)]
            public AkSkIdentityConfig AkSkIdentityConfigs { get; set; }

            [NameInMap("apiKeyIdentityConfig")]
            [Validation(Required=false)]
            public ApiKeyIdentityConfig ApiKeyIdentityConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cs-cvgbtk6m1hkji5sb8dr0</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("jwtIdentityConfig")]
            [Validation(Required=false)]
            public JwtIdentityConfig JwtIdentityConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>consumer-1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>880C61B3-7B90-5570-A3F7-D6D92C0E2D36</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
