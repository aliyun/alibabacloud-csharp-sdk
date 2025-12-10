// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSecurityGroupPermissionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The security group rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string PermissionsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
