// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListRamRolesResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRamRolesResponseBodyResult> Result { get; set; }
        public class ListRamRolesResponseBodyResult : TeaModel {
            [NameInMap("assumed")]
            [Validation(Required=false)]
            public bool? Assumed { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
