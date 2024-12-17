// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class DescribeServiceLinkedRoleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EntityRoleGrant")]
        [Validation(Required=false)]
        public bool? EntityRoleGrant { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>02F8BBF3-2D61-5982-8911-EEB387BE3AF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
