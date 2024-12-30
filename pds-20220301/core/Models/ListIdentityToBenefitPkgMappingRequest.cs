// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListIdentityToBenefitPkgMappingRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the entity.</para>
        /// <para>If you call this operation to manage the benefits of a user, set this parameter to the ID of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// <para>The type of the entity. If you call this operation to manage the benefits of a user, set this parameter to user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the benefit packages that expire. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("include_expired")]
        [Validation(Required=false)]
        public bool? IncludeExpired { get; set; }

    }

}
