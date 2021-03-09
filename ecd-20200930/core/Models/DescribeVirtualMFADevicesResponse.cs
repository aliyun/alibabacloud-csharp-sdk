// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVirtualMFADevicesResponse : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("VirtualMFADevices")]
        [Validation(Required=true)]
        public List<DescribeVirtualMFADevicesResponseVirtualMFADevices> VirtualMFADevices { get; set; }
        public class DescribeVirtualMFADevicesResponseVirtualMFADevices : TeaModel {
            [NameInMap("DirectoryId")]
            [Validation(Required=true)]
            public string DirectoryId { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=true)]
            public string EndUserId { get; set; }

            [NameInMap("GmtEnabled")]
            [Validation(Required=true)]
            public string GmtEnabled { get; set; }

            [NameInMap("GmtUnlock")]
            [Validation(Required=true)]
            public string GmtUnlock { get; set; }

            [NameInMap("ConsecutiveFails")]
            [Validation(Required=true)]
            public int? ConsecutiveFails { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=true)]
            public string SerialNumber { get; set; }

            [NameInMap("status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

    }

}
