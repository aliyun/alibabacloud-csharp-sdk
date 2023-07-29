// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttachRecordsResponseBody : TeaModel {
        [NameInMap("AccessList")]
        [Validation(Required=false)]
        public List<DescribeAttachRecordsResponseBodyAccessList> AccessList { get; set; }
        public class DescribeAttachRecordsResponseBodyAccessList : TeaModel {
            [NameInMap("AttachState")]
            [Validation(Required=false)]
            public long? AttachState { get; set; }

            [NameInMap("AttachSwitch")]
            [Validation(Required=false)]
            public string AttachSwitch { get; set; }

            [NameInMap("EcsUUID")]
            [Validation(Required=false)]
            public string EcsUUID { get; set; }

            [NameInMap("InstallMsg")]
            [Validation(Required=false)]
            public string InstallMsg { get; set; }

            [NameInMap("InstallState")]
            [Validation(Required=false)]
            public long? InstallState { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
