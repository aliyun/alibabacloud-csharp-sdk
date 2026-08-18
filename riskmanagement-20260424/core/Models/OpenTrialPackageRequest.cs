// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class OpenTrialPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically disable the trial plan when it expires.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoCloseSwitch")]
        [Validation(Required=false)]
        public int? AutoCloseSwitch { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
