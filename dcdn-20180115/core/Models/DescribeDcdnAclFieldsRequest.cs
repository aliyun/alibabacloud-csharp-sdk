// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnAclFieldsRequest : TeaModel {
        /// <summary>
        /// The access language. Default value: en. Valid values:
        /// 
        /// *   **en**: English
        /// *   **zh**: Chinese
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
