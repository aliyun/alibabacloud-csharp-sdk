// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAccessControlListsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACLs.</para>
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
                /// <para>The ID of the access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-3nsohdozz0ru8fi5onwz1</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>The name of the access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testAcl</para>
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                /// <summary>
                /// <para>访问控制策略组的IP版本。</para>
                /// <list type="bullet">
                /// <item><description><b>IPv4</b>。</description></item>
                /// <item><description><b>IPv6</b>。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
