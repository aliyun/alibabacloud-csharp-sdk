// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchUserResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<User> Items { get; set; }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
