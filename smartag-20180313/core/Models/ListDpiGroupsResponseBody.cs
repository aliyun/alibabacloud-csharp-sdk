// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiGroupsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DpiGroup")]
        [Validation(Required=false)]
        public List<ListDpiGroupsResponseBodyDpiGroup> DpiGroup { get; set; }
        public class ListDpiGroupsResponseBodyDpiGroup : TeaModel {
            [NameInMap("MinSignatureDbVersion")]
            [Validation(Required=false)]
            public string MinSignatureDbVersion { get; set; }

            [NameInMap("DpiGroupName")]
            [Validation(Required=false)]
            public string DpiGroupName { get; set; }

            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public string DpiGroupId { get; set; }

            [NameInMap("MinEngineVersion")]
            [Validation(Required=false)]
            public string MinEngineVersion { get; set; }

        }

    }

}
