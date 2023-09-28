// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateTagOptionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the tag option. Valid values:
        /// 
        /// *   true (default)
        /// *   false
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The ID of the tag option.
        /// </summary>
        [NameInMap("TagOptionId")]
        [Validation(Required=false)]
        public string TagOptionId { get; set; }

        /// <summary>
        /// The value of the tag option.
        /// 
        /// The value can be up to 128 characters in length. It cannot start with `acs:` and cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
