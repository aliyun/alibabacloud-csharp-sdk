// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateMemberApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time in the format of yyyy-MM-dd HH:mm:ss. This parameter is optional. If not specified, the key is permanently valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-07-31 00:00:00</para>
        /// </summary>
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        /// <summary>
        /// <para>The name of the API key. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKey</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
