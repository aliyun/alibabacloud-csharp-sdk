// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class IdentityToBenefitPkgMapping : TeaModel {
        [NameInMap("benefit_pkg_computation_rule")]
        [Validation(Required=false)]
        public string BenefitPkgComputationRule { get; set; }

        [NameInMap("benefit_pkg_id")]
        [Validation(Required=false)]
        public string BenefitPkgId { get; set; }

        [NameInMap("benefit_pkg_name")]
        [Validation(Required=false)]
        public string BenefitPkgName { get; set; }

        [NameInMap("benefit_pkg_owner_id")]
        [Validation(Required=false)]
        public string BenefitPkgOwnerId { get; set; }

        [NameInMap("benefit_pkg_priority")]
        [Validation(Required=false)]
        public long? BenefitPkgPriority { get; set; }

        [NameInMap("benefit_pkg_type")]
        [Validation(Required=false)]
        public string BenefitPkgType { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("delivery_info_list")]
        [Validation(Required=false)]
        public List<BenefitPkgDeliveryInfo> DeliveryInfoList { get; set; }

        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
