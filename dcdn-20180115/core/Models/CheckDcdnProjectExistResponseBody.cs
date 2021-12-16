// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CheckDcdnProjectExistResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CheckDcdnProjectExistResponseBodyContent Content { get; set; }
        public class CheckDcdnProjectExistResponseBodyContent : TeaModel {
            [NameInMap("Exist")]
            [Validation(Required=false)]
            public string Exist { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
