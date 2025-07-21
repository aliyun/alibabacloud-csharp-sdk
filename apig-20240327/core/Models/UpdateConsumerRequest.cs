// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateConsumerRequest : TeaModel {
        [NameInMap("akSkIdentityConfigs")]
        [Validation(Required=false)]
        public List<AkSkIdentityConfig> AkSkIdentityConfigs { get; set; }

        [NameInMap("apikeyIdentityConfig")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfig ApikeyIdentityConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("jwtIdentityConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfig JwtIdentityConfig { get; set; }

    }

}
