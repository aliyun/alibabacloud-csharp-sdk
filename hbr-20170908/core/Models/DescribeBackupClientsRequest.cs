// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsRequest : TeaModel {
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ClientIds { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceIds { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsRequestTag> Tag { get; set; }
        public class DescribeBackupClientsRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
