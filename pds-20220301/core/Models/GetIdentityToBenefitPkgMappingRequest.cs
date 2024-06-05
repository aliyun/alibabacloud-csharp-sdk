// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetIdentityToBenefitPkgMappingRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the benefit package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("benefit_pkg_id")]
        [Validation(Required=false)]
        public string BenefitPkgId { get; set; }

        /// <summary>
        /// The unique identifier of the entity.
        /// 
        /// If you want to manage the benefits of a user, set this parameter to a user ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// The type of the entity. If you want to manage the benefits of a user, set this parameter to user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
