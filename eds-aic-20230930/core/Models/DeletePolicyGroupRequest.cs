// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DeletePolicyGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of policy IDs. If any policy is associated with an undeleted instance group, the entire deletion operation fails.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyGroupIds")]
        [Validation(Required=false)]
        public List<string> PolicyGroupIds { get; set; }

    }

}
