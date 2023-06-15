// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The language that is used for the return value of the **LocalName** parameter. Valid values:
        /// 
        /// *   **zh-CN**: Chinese
        /// *   **en-US**: English
        /// 
        /// Default value: **en-US**.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
