// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListAttributeResponseBody : TeaModel {
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyAclEntrys AclEntrys { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyAclEntrys : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry> AclEntry { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry : TeaModel {
                [NameInMap("AclEntryComment")]
                [Validation(Required=false)]
                public string AclEntryComment { get; set; }

                [NameInMap("AclEntryIP")]
                [Validation(Required=false)]
                public string AclEntryIP { get; set; }

            }

        }

        /// <summary>
        /// <para>The ACL ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-bp1ut10zzvh1y8dfs****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ACL name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values: <b>ipv4</b> and <b>ipv6</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The time when the ACL was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-31T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyRelatedListeners RelatedListeners { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyRelatedListeners : TeaModel {
            [NameInMap("RelatedListener")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyRelatedListenersRelatedListener> RelatedListener { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyRelatedListenersRelatedListener : TeaModel {
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9906A1D-86F7-4C9C-A369-54DA42EF206A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmz3jksig****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyTags Tags { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyTagsTag : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of ACL entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalAclEntry")]
        [Validation(Required=false)]
        public int? TotalAclEntry { get; set; }

    }

}
