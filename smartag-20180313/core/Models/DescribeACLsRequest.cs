// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeACLsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL.</para>
        /// <list type="bullet">
        /// <item><description>If you want to query multiple ACLs at the same time, separate the ACL IDs with commas (,).</description></item>
        /// <item><description>If you do not set this parameter, all ACLs in the specified region are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l*******</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public string AclIds { get; set; }

        /// <summary>
        /// <para>The type of the SAG instance associated with the ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>acl-hardware</b>: SAG CPE instance</description></item>
        /// <item><description><b>acl-software</b>: SAG app instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acl-hardware</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The name of the ACL.</para>
        /// <para>The name must be 2 to 100 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the ACL is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
