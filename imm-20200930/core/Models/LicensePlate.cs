// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class LicensePlate : TeaModel {
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public double? Confidence { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>川A0123</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
