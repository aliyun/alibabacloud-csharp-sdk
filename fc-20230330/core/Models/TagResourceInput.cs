// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TagResourceInput : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
