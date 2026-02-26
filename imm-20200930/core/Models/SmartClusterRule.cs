// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SmartClusterRule : TeaModel {
        /// <summary>
        /// <para>Keywords</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>Sensitivity</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Sensitivity")]
        [Validation(Required=false)]
        public float? Sensitivity { get; set; }

    }

}
