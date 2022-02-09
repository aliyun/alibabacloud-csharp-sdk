// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLinksResponseBody : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DBLinkInfos")]
        [Validation(Required=false)]
        public List<DescribeDBLinksResponseBodyDBLinkInfos> DBLinkInfos { get; set; }
        public class DescribeDBLinksResponseBodyDBLinkInfos : TeaModel {
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("DBLinkName")]
            [Validation(Required=false)]
            public string DBLinkName { get; set; }

            [NameInMap("SourceDBName")]
            [Validation(Required=false)]
            public string SourceDBName { get; set; }

            [NameInMap("TargetAccount")]
            [Validation(Required=false)]
            public string TargetAccount { get; set; }

            [NameInMap("TargetDBInstanceName")]
            [Validation(Required=false)]
            public string TargetDBInstanceName { get; set; }

            [NameInMap("TargetDBName")]
            [Validation(Required=false)]
            public string TargetDBName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
