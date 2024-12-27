// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SmartClusterRule : TeaModel {
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Sensitivity")]
        [Validation(Required=false)]
        public float? Sensitivity { get; set; }

    }

}
