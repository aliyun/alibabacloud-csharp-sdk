// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeBlockedRegionsRequest : TeaModel {
        /// <summary>
        /// The language. Valid values:
        /// 
        /// *   **zh**: simplified Chinese
        /// *   **en**: English
        /// *   **jp**: Japanese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
