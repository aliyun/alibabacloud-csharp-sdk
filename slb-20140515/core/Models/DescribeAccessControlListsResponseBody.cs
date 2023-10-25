// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListsResponseBody : TeaModel {
        /// <summary>
        /// A list of ACLs.
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public DescribeAccessControlListsResponseBodyAcls Acls { get; set; }
        public class DescribeAccessControlListsResponseBodyAcls : TeaModel {
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListsResponseBodyAclsAcl> Acl { get; set; }
            public class DescribeAccessControlListsResponseBodyAclsAcl : TeaModel {
                /// <summary>
                /// The ACL ID.
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// The ACL name.
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                /// <summary>
                /// The IP version that is used by the CLB instance associated with the ACL.
                /// </summary>
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                /// <summary>
                /// The time when the CLB instance was created. The time follows the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The list of tags added to the network ACL. The value of this parameter must be a STRING list in the JSON format.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAccessControlListsResponseBodyAclsAclTags Tags { get; set; }
                public class DescribeAccessControlListsResponseBodyAclsAclTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeAccessControlListsResponseBodyAclsAclTagsTag> Tag { get; set; }
                    public class DescribeAccessControlListsResponseBodyAclsAclTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The number of ACLs on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The number of the returned page. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of ACLs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
