// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionResourceRequest : TeaModel {
        /// <summary>
        /// The output level.
        /// 
        /// Valid values:
        /// 
        /// *   simple
        /// *   normal
        /// *   detail
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

    }

}
