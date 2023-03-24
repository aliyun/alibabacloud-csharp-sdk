// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DetachApplication2ConnectorShrinkRequest : TeaModel {
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public string ApplicationIdsShrink { get; set; }

        /// <summary>
        /// ConnectorID。
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

    }

}
