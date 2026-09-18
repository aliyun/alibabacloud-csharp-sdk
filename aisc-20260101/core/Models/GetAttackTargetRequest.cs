// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GetAttackTargetRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the scan target. If the target does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-abc123def4567</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
