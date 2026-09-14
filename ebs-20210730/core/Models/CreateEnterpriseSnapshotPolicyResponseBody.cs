// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateEnterpriseSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The snapshot policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esp-xxx</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F13483A9-17E2-5085-9B2E-2155B0487FF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
