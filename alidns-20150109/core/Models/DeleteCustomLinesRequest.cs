// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteCustomLinesRequest : TeaModel {
        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The unique IDs of the custom lines that you want to delete. Separate the unique IDs with commas (,).
        /// </summary>
        [NameInMap("LineIds")]
        [Validation(Required=false)]
        public string LineIds { get; set; }

    }

}
