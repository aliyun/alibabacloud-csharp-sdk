// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BNetwork : TeaModel {
        [NameInMap("allowOut")]
        [Validation(Required=false)]
        public List<string> AllowOut { get; set; }

        [NameInMap("allowPublicTraffic")]
        [Validation(Required=false)]
        public bool? AllowPublicTraffic { get; set; }

        [NameInMap("denyOut")]
        [Validation(Required=false)]
        public List<string> DenyOut { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sandbox.example.com</para>
        /// </summary>
        [NameInMap("maskRequestHost")]
        [Validation(Required=false)]
        public string MaskRequestHost { get; set; }

    }

}
