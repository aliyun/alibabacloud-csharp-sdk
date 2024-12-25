// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of ACLs.</para>
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
                /// <para>The ACL ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-bp1l0kk4gxce43k*****</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>The ACL name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule1</para>
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                /// <summary>
                /// <para>The IP version that is used by the CLB instance associated with the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                /// <summary>
                /// <para>The time when the CLB instance was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-31T02:49:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-jfenfbp1lhl0****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The list of tags added to the network ACL. The value of this parameter must be a STRING list in the JSON format.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The number of ACLs on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The number of the returned page. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CB646EF-6147-4566-A9D9-CE8FBE86F971</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of ACLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
