// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RevokeConsumerModelCardGrantsRequest : TeaModel {
        /// <summary>
        /// <para>The collection of model card IDs to be revoked within this API. Revoking a non-existent license is a valid no-op.</para>
        /// </summary>
        [NameInMap("modelCardIds")]
        [Validation(Required=false)]
        public List<string> ModelCardIds { get; set; }

        /// <summary>
        /// <para>The collection of actual model group IDs to be revoked within this API. When revoking only group licenses, modelCardIds can be empty, and the group or principal is not required to exist. At least one of the two target types must be non-empty. This operation does not delete consumers, keys, or quotas.</para>
        /// </summary>
        [NameInMap("modelGroupIds")]
        [Validation(Required=false)]
        public List<string> ModelGroupIds { get; set; }

        /// <summary>
        /// <para>The immutable ID of the principal for which the license is revoked. This is not the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-d00000000000000000000</para>
        /// </summary>
        [NameInMap("principalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the principal for which the license is revoked. Valid values: Consumer and ConsumerGroup.</para>
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
