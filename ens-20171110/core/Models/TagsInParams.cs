// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class TagsInParams : TeaModel {
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagsInParamsTag> Tag { get; set; }
        public class TagsInParamsTag : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
