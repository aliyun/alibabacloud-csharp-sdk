// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListIdentityToBenefitPkgMappingRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the entity.
        /// 
        /// If you call this operation to manage the benefits of a user, set this parameter to the ID of the user.
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// The type of the entity. If you call this operation to manage the benefits of a user, set this parameter to user.
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// Specifies whether to return the benefit packages that expire. Default value: false.
        /// </summary>
        [NameInMap("include_expired")]
        [Validation(Required=false)]
        public bool? IncludeExpired { get; set; }

    }

}
