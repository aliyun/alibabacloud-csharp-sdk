// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAccessControlListAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-3nsohdozz0ru8fi5onwz1</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
