// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyAttachmentsResponseBody : TeaModel {
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
        /// The policy attachment records.
        /// </summary>
        [NameInMap("PolicyAttachments")]
        [Validation(Required=false)]
        public ListPolicyAttachmentsResponseBodyPolicyAttachments PolicyAttachments { get; set; }
        public class ListPolicyAttachmentsResponseBodyPolicyAttachments : TeaModel {
            [NameInMap("PolicyAttachment")]
            [Validation(Required=false)]
            public List<ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment> PolicyAttachment { get; set; }
            public class ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment : TeaModel {
                /// <summary>
                /// The time when the policy was attached.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// The description of the policy.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the policy.
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// The type of the policy. Valid values:
                /// 
                /// *   Custom: custom policy
                /// *   System: system policy
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// The name of the object to which the policy is attached.
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// The type of the object to which the policy is attached. Valid values:
                /// 
                /// *   IMSUser: RAM user
                /// *   IMSGroup: RAM user group
                /// *   ServiceRole: RAM role
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// The ID of the resource group or the ID of the Alibaba Cloud account to which the resource group belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
