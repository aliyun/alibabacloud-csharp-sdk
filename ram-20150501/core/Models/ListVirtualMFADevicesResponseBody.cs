// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListVirtualMFADevicesResponseBody : TeaModel {
        [NameInMap("VirtualMFADevices")]
        [Validation(Required=false)]
        public List<ListVirtualMFADevicesResponseBodyVirtualMFADevices> VirtualMFADevices { get; set; }
        public class ListVirtualMFADevicesResponseBodyVirtualMFADevices : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public ListVirtualMFADevicesResponseBodyVirtualMFADevicesUser User { get; set; }
            public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesUser : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }
            };

            [NameInMap("ActivateDate")]
            [Validation(Required=false)]
            public string ActivateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
