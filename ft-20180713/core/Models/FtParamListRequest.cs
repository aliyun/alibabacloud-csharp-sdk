// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ft20180713.Models
{
    public class FtParamListRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<FtParamListRequestDisk> Disk { get; set; }
        public class FtParamListRequestDisk : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public List<string> Type { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public List<string> Size { get; set; }

        }

    }

}
