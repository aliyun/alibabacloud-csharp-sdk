// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListControlPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The information of the access control policies.
        /// </summary>
        [NameInMap("ControlPolicies")]
        [Validation(Required=false)]
        public ListControlPoliciesResponseBodyControlPolicies ControlPolicies { get; set; }
        public class ListControlPoliciesResponseBodyControlPolicies : TeaModel {
            [NameInMap("ControlPolicy")]
            [Validation(Required=false)]
            public List<ListControlPoliciesResponseBodyControlPoliciesControlPolicy> ControlPolicy { get; set; }
            public class ListControlPoliciesResponseBodyControlPoliciesControlPolicy : TeaModel {
                /// <summary>
                /// The number of times that the access control policy is referenced.
                /// </summary>
                [NameInMap("AttachmentCount")]
                [Validation(Required=false)]
                public string AttachmentCount { get; set; }

                /// <summary>
                /// The time when the access control policy was created.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The description of the access control policy.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The effective scope of the access control policy. Valid values:
                /// 
                /// *   All: The access control policy is in effect for Alibaba Cloud accounts, RAM users, and RAM roles.
                /// *   RAM: The access control policy is in effect only for RAM users and RAM roles.
                /// </summary>
                [NameInMap("EffectScope")]
                [Validation(Required=false)]
                public string EffectScope { get; set; }

                /// <summary>
                /// The ID of the access control policy.
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// The name of the access control policy.
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// The type of the access control policy. Valid values:
                /// 
                /// *   System: system access control policy
                /// *   Custom: custom access control policy
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// The time when the access control policy was updated.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of access control policies.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
