// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Boundary : TeaModel {
        /// <summary>
        /// Width
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// Left
        /// </summary>
        [NameInMap("Left")]
        [Validation(Required=false)]
        public long? Left { get; set; }

        /// <summary>
        /// Top
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public long? Top { get; set; }

    }

}
