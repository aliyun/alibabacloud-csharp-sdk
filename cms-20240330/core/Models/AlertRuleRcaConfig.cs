// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleRcaConfig : TeaModel {
        /// <summary>
        /// <para>The digital employee name.</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>Indicates whether RCA is enabled.</para>
        /// </summary>
        [NameInMap("enableRca")]
        [Validation(Required=false)]
        public bool? EnableRca { get; set; }

    }

}
