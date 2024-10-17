// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the automatic snapshot policy.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/126583.html">DescribeAutoSnapshotPolicies</a> operation to view available automatic snapshot policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-extreme-233e6****</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

    }

}
