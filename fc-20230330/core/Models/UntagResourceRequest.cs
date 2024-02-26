// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UntagResourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete all tags.
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The resource ID.
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The tag name.
        /// </summary>
        [NameInMap("tagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}
