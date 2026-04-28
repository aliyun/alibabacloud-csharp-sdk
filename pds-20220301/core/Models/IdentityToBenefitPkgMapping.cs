// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class IdentityToBenefitPkgMapping : TeaModel {
        /// <summary>
        /// <para>Calculation rules of equity in the benefit package.</para>
        /// <para>The user identity benefit package. The return value is empty. Only the quota of the effective equity is calculated based on the priority.</para>
        /// <para>The user resource benefit package, which can return null or non-null values. If the return value is not empty, this benefit package is used to append the quota of existing benefits in other benefit packages, which is limited to quota-type benefits. For example, if a user identity benefit package already contains 10 GB of user storage capacity, you can define one or more user resource benefit packages to add additional storage capacity for some users.</para>
        /// <para>The following append calculation rules are supported:</para>
        /// <para>sum: Multiple benefit packages have the same equity and are accumulated.</para>
        /// <para>max: If multiple benefit packages have the same equity, the max value is used.</para>
        /// <para>min: If multiple benefit packages have the same equity, the value of min is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sum</para>
        /// </summary>
        [NameInMap("benefit_pkg_computation_rule")]
        [Validation(Required=false)]
        public string BenefitPkgComputationRule { get; set; }

        /// <summary>
        /// <para>The ID of the benefit package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40cb7794c9294</para>
        /// </summary>
        [NameInMap("benefit_pkg_id")]
        [Validation(Required=false)]
        public string BenefitPkgId { get; set; }

        /// <summary>
        /// <para>The name of the benefit package.</para>
        /// </summary>
        [NameInMap("benefit_pkg_name")]
        [Validation(Required=false)]
        public string BenefitPkgName { get; set; }

        /// <summary>
        /// <para>The ID of the owner of the benefit package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("benefit_pkg_owner_id")]
        [Validation(Required=false)]
        public string BenefitPkgOwnerId { get; set; }

        /// <summary>
        /// <para>Priority of the benefit package.</para>
        /// <para>The priority returned for the user identity benefit package. A smaller number indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("benefit_pkg_priority")]
        [Validation(Required=false)]
        public long? BenefitPkgPriority { get; set; }

        /// <summary>
        /// <para>The type of benefit package.</para>
        /// <para>Valid values:</para>
        /// <para>user_identity : user identity benefit package</para>
        /// <para>user_resource: user resource benefit package</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_identity</para>
        /// </summary>
        [NameInMap("benefit_pkg_type")]
        [Validation(Required=false)]
        public string BenefitPkgType { get; set; }

        /// <summary>
        /// <para>Creation time of the entity and benefit package association.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The information about the benefit packages that are associated with an entity.</para>
        /// </summary>
        [NameInMap("delivery_info_list")]
        [Validation(Required=false)]
        public List<BenefitPkgDeliveryInfo> DeliveryInfoList { get; set; }

        /// <summary>
        /// <para>The ID of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// <para>The type of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>Update time associated with the entity and benefit package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
