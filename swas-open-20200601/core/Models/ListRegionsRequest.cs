// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListRegionsRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   **zh-CN** (default): Chinese
        /// *   **en-US**: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
