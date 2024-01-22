// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RescaleApplicationVerticallyRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The destination CPU specification. Unit: millicore.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// The destination memory size. Unit: MB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
