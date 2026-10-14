// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DisableSceneDefensePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy to disable.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/159382.html">DescribeSceneDefensePolicies</a> to query all policy IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>321a-fd31-df51-****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
