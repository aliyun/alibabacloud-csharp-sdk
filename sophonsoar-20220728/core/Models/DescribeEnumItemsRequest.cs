// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeEnumItemsRequest : TeaModel {
        /// <summary>
        /// The type of the enumeration item. Valid values:
        /// 
        /// *   **process**: scenarios
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnumType")]
        [Validation(Required=false)]
        public string EnumType { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh_cn**: Simplified Chinese (default)
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
