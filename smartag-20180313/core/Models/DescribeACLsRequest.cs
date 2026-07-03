// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeACLsRequest : TeaModel {
        /// <summary>
        /// <para>The access control instance ID.</para>
        /// <list type="bullet">
        /// <item><description>To query multiple access control instances simultaneously, separate multiple instance IDs with commas (,).</description></item>
        /// <item><description>If this parameter is not specified, information about all access control instances in the current region is queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l*******</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public string AclIds { get; set; }

        /// <summary>
        /// <para>The type of Smart Access Gateway (SAG) instance that the access control instance can be associated with. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>acl-hardware</b>: SAG hardware instance.</description></item>
        /// <item><description><b>acl-software</b>: SAG app instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acl-hardware</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The name of the access control instance.</para>
        /// <para>The name must be 2 to 100 characters in length and must start with an uppercase letter, lowercase letter, or Chinese character. The name can contain digits, underscores (_), periods (.), and hyphens (-).</para>
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paginated query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the access control instance.</para>
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
