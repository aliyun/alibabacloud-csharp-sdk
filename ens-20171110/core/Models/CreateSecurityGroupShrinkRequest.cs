// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSecurityGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description. The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Schema of Response</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string PermissionsShrink { get; set; }

        /// <summary>
        /// <para>The name of the security group. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (<em>), and hyphens (-). It must start with a letter but cannot start with http:// or https://. It can contain letters, digits, colons (:), underscores (</em>), and hyphens (-). By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dcdn1:2_3-4</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
