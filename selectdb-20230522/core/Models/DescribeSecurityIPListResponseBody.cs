// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeSecurityIPListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
