// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiPolicyRedisConfig : TeaModel {
        /// <summary>
        /// <para>The zero-based index of the Redis database to use. The default value is 0.</para>
        /// </summary>
        [NameInMap("databaseNumber")]
        [Validation(Required=false)]
        public int? DatabaseNumber { get; set; }

        /// <summary>
        /// <para>The hostname of the Redis instance.</para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The password for Redis authentication.</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port number of the Redis instance.</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The connection timeout in milliseconds.</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The username for Redis authentication.</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
