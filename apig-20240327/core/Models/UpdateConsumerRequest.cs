// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateConsumerRequest : TeaModel {
        /// <summary>
        /// <para>The list of AK/SK authentication configurations.</para>
        /// </summary>
        [NameInMap("akSkIdentityConfigs")]
        [Validation(Required=false)]
        public List<AkSkIdentityConfig> AkSkIdentityConfigs { get; set; }

        /// <summary>
        /// <para>The API key authentication configurations.</para>
        /// </summary>
        [NameInMap("apikeyIdentityConfig")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfig ApikeyIdentityConfig { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies the enablement status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The JWT authentication configuration.</para>
        /// </summary>
        [NameInMap("jwtIdentityConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfig JwtIdentityConfig { get; set; }

    }

}
