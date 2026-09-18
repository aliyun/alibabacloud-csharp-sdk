// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class DeleteAttackTargetRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the scan target. This is the TargetId returned by CreateAttackTarget or ListAttackTargets. If the target does not exist or belongs to another tenant, a 400 error is returned. This prevents exposing whether the resource exists.</para>
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
