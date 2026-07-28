// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class UpdateAccessControlListRequest : TeaModel {
        /// <summary>
        /// <para>The public access control ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-123xxx</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c>/24,<c>172.1.**.**</c>/16</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-123xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
