// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateIdentityToBenefitPkgMappingRequest : TeaModel {
        /// <summary>
        /// The number of benefit packages.
        /// 
        /// This parameter specifies the number of benefit packages of the resource type. Default value: 1.
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// The unique identifier of the benefit package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("benefit_pkg_id")]
        [Validation(Required=false)]
        public string BenefitPkgId { get; set; }

        /// <summary>
        /// The expiration time of the benefit package. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// By default, the benefit package never expires.
        /// </summary>
        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// The unique identifier of the entity.
        /// 
        /// If you call this operation to manage the benefits of a user, set this parameter to the ID of the user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// The type of the entity. If you call this operation to manage the benefits of a user, set this parameter to user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
