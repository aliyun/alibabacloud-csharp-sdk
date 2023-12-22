// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutLayerACLRequest : TeaModel {
        /// <summary>
        /// Specifies whether the layer is public.
        /// 
        /// *   **true**: Public.
        /// *   **false**: Not public.
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

    }

}
