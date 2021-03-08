// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20170601.Models
{
    public class DescribeHiTSDBInstanceSecurityIpListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public List<DescribeHiTSDBInstanceSecurityIpListResponseBodySecurityIpList> SecurityIpList { get; set; }
        public class DescribeHiTSDBInstanceSecurityIpListResponseBodySecurityIpList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
