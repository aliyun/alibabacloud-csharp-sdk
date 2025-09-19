// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteAttackPathSensitiveAssetConfigRequest : TeaModel {
        /// <summary>
        /// <para>ID of the attack path sensitive asset configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apsac-123</para>
        /// </summary>
        [NameInMap("AttackPathSensitiveAssetConfigId")]
        [Validation(Required=false)]
        public string AttackPathSensitiveAssetConfigId { get; set; }

    }

}
