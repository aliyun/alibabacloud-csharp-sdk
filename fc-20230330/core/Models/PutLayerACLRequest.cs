// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutLayerACLRequest : TeaModel {
        /// <summary>
        /// Specify the access permission of the layer. A value of 1 indicates public and a value of 0 indicates private. The default value is 0.
        /// </summary>
        [NameInMap("acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        /// <summary>
        /// Specify whether the layer is a public layer. Valid values: true and false.
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        [Obsolete]
        public string Public { get; set; }

    }

}
