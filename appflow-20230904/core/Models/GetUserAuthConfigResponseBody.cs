// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class GetUserAuthConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>458CB9FE-8C71-58A8-AD49-97EF28D58FAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserAuthConfig")]
        [Validation(Required=false)]
        public GetUserAuthConfigResponseBodyUserAuthConfig UserAuthConfig { get; set; }
        public class GetUserAuthConfigResponseBodyUserAuthConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;apiKey&quot;:\&quot;xxxxxxxxxx\&quot;}</para>
            /// </summary>
            [NameInMap("AuthConfig")]
            [Validation(Required=false)]
            public string AuthConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uac-111111111</para>
            /// </summary>
            [NameInMap("AuthConfigId")]
            [Validation(Required=false)]
            public string AuthConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtlak_name</para>
            /// </summary>
            [NameInMap("AuthConfigName")]
            [Validation(Required=false)]
            public string AuthConfigName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ApiKey</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>connector-172176821387</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConnectorVersion")]
            [Validation(Required=false)]
            public string ConnectorVersion { get; set; }

        }

    }

}
