// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateConsumerAuthorizationRuleRequest : TeaModel {
        [NameInMap("authorizationResourceInfos")]
        [Validation(Required=false)]
        public List<AuthorizationResourceInfo> AuthorizationResourceInfos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LongTerm</para>
        /// </summary>
        [NameInMap("expireMode")]
        [Validation(Required=false)]
        public string ExpireMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1750852089975</para>
        /// </summary>
        [NameInMap("expireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

    }

}
