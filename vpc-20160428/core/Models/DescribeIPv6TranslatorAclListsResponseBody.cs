// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorAclListsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network ACLs.</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorAcls")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAcls Ipv6TranslatorAcls { get; set; }
        public class DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAcls : TeaModel {
            [NameInMap("IPv6TranslatorAcl")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAclsIPv6TranslatorAcl> IPv6TranslatorAcl { get; set; }
            public class DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAclsIPv6TranslatorAcl : TeaModel {
                /// <summary>
                /// <para>The ACL ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6transacl-bp1de2****</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>The ACL name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl1</para>
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
