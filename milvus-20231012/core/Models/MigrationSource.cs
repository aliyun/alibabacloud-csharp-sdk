// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class MigrationSource : TeaModel {
        /// <summary>
        /// <para>The authentication information of the migration source.</para>
        /// </summary>
        [NameInMap("authInfo")]
        [Validation(Required=false)]
        public MigrationSourceAuthInfo AuthInfo { get; set; }
        public class MigrationSourceAuthInfo : TeaModel {
            /// <summary>
            /// <para>The authentication type.</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The password used for authentication.</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The token used for authentication.</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The username used for authentication.</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The name of the database to migrate.</para>
        /// </summary>
        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The endpoint information of the migration source.</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public MigrationSourceEndpoint Endpoint { get; set; }
        public class MigrationSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The endpoint address of the migration source.</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The port number of the migration source.</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

    }

}
