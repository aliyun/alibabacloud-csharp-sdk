// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class EffectivePermissions : TeaModel {
        /// <summary>
        /// <para>The actions.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// <para>The capabilities.</para>
        /// </summary>
        [NameInMap("capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

    }

}
