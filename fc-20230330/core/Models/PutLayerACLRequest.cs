// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutLayerACLRequest : TeaModel {
        /// <summary>
        /// Specifies whether the layer is a public layer. Valid values: true and false.
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        public string Public { get; set; }

    }

}
