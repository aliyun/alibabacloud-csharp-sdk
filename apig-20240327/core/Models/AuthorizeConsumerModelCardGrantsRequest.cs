// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AuthorizeConsumerModelCardGrantsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the selected model cards for this API. You can leave this parameter empty or omit it, but at least one of modelCardIds and modelGroupIds must be specified.</para>
        /// </summary>
        [NameInMap("modelCardIds")]
        [Validation(Required=false)]
        public List<string> ModelCardIds { get; set; }

        /// <summary>
        /// <para>The actual model group IDs of the current instance. You can leave modelCardIds empty only when you grant group entitlements. Group entitlements allow zero intersection with the current API, but you cannot save principal relationships if both target types are empty.</para>
        /// </summary>
        [NameInMap("modelGroupIds")]
        [Validation(Required=false)]
        public List<string> ModelGroupIds { get; set; }

        /// <summary>
        /// <para>The immutable ID of the authorization principal. This is not the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-d00000000000000000000</para>
        /// </summary>
        [NameInMap("principalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the authorization principal. Valid values: Consumer and ConsumerGroup.</para>
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
