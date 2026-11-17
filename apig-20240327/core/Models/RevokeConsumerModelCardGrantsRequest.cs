// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RevokeConsumerModelCardGrantsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the model cards for which entitlements are revoked in this API. Revoking non-existent entitlements is a valid no-op.</para>
        /// </summary>
        [NameInMap("modelCardIds")]
        [Validation(Required=false)]
        public List<string> ModelCardIds { get; set; }

        /// <summary>
        /// <para>The IDs of the actual model groups for which entitlements are revoked in this API. If you revoke only group entitlements, modelCardIds can be empty, and the group or principal is not required to exist. At least one of the two target types must be specified. This operation does not delete consumers, keys, or quotas.</para>
        /// </summary>
        [NameInMap("modelGroupIds")]
        [Validation(Required=false)]
        public List<string> ModelGroupIds { get; set; }

        /// <summary>
        /// <para>The immutable ID of the principal for which entitlements are revoked. This is not the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-d00000000000000000000</para>
        /// </summary>
        [NameInMap("principalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the principal for which entitlements are revoked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Consumer</description></item>
        /// <item><description>ConsumerGroup</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Consumer</para>
        /// </summary>
        [NameInMap("principalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

    }

}
