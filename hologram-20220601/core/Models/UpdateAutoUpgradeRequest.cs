// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateAutoUpgradeRequest : TeaModel {
        /// <summary>
        /// <para>The upgrade type. Valid values: <c>auto</c> and <c>manual</c>. A value of auto specifies to enable automatic minor version upgrades. A value of manual specifies to disable automatic minor version upgrades.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("autoUpgrade")]
        [Validation(Required=false)]
        public string AutoUpgrade { get; set; }

    }

}
