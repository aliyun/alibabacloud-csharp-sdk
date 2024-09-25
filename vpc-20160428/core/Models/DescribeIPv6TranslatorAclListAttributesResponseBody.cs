// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorAclListAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACLs.</para>
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntries AclEntries { get; set; }
        public class DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntries : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntriesAclEntry> AclEntry { get; set; }
            public class DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntriesAclEntry : TeaModel {
                /// <summary>
                /// <para>The remarks of the ACL entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client IP</para>
                /// </summary>
                [NameInMap("AclEntryComment")]
                [Validation(Required=false)]
                public string AclEntryComment { get; set; }

                /// <summary>
                /// <para>The ID of the ACL entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6transaclentry-bp105jrs****</para>
                /// </summary>
                [NameInMap("AclEntryId")]
                [Validation(Required=false)]
                public string AclEntryId { get; set; }

                /// <summary>
                /// <para>The IP address specified in the ACL entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12ab:0:0:XXXX::0102/128</para>
                /// </summary>
                [NameInMap("AclEntryIp")]
                [Validation(Required=false)]
                public string AclEntryIp { get; set; }

            }

        }

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
        /// <para>The name of the ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl1</para>
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
