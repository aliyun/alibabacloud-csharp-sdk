// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterBatchRenewMemberApiKeysRequest : TeaModel {
        /// <summary>
        /// <para>The new expiration time in RFC 3339 format. The time must be later than the current time. If this parameter is not provided or is set to null, the API keys remain permanently valid. This parameter only modifies the validity period and does not change the enabled or disabled status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-01-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        /// <summary>
        /// <para>The list of member user IDs. This operation renews all undeleted API keys of these members in the specified department.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

    }

}
