// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeSecurityIPListResponseBody : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("GroupItems")]
        [Validation(Required=false)]
        public List<DescribeSecurityIPListResponseBodyGroupItems> GroupItems { get; set; }
        public class DescribeSecurityIPListResponseBodyGroupItems : TeaModel {
            [NameInMap("AecurityIPType")]
            [Validation(Required=false)]
            public string AecurityIPType { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("GroupTag")]
            [Validation(Required=false)]
            public string GroupTag { get; set; }

            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            [NameInMap("WhitelistNetType")]
            [Validation(Required=false)]
            public string WhitelistNetType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
