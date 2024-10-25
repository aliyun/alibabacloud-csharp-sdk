// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAclsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-bp1lhl0taikrbgnh****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>The name of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-1</para>
        /// </summary>
        [NameInMap("NetworkAclName")]
        [Validation(Required=false)]
        public string NetworkAclName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the associated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
