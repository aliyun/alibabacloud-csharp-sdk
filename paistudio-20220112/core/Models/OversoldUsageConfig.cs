// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class OversoldUsageConfig : TeaModel {
        /// <summary>
        /// <para>Indicates whether it is disabled.</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>The user who disabled it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxx</para>
        /// </summary>
        [NameInMap("DisabledBy")]
        [Validation(Required=false)]
        public string DisabledBy { get; set; }

    }

}
