// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUsersWithPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12B94024-C241-13CD-BA44-6106DF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of the IDs of the RAM users or RAM roles to which an RBAC role is assigned.</para>
        /// </summary>
        [NameInMap("UIDs")]
        [Validation(Required=false)]
        public List<string> UIDs { get; set; }

    }

}
