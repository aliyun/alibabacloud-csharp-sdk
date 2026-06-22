// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackPathSensitiveAssetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the attack path sensitive asset configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apsac-123</para>
        /// </summary>
        [NameInMap("AttackPathSensitiveAssetConfigId")]
        [Validation(Required=false)]
        public string AttackPathSensitiveAssetConfigId { get; set; }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asset_instance: asset.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asset_instance</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

    }

}
