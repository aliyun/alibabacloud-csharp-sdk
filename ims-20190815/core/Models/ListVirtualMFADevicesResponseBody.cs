// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListVirtualMFADevicesResponseBody : TeaModel {
        [NameInMap("VirtualMFADevices")]
        [Validation(Required=false)]
        public ListVirtualMFADevicesResponseBodyVirtualMFADevices VirtualMFADevices { get; set; }
        public class ListVirtualMFADevicesResponseBodyVirtualMFADevices : TeaModel {
            [NameInMap("VirtualMFADevice")]
            [Validation(Required=false)]
            public List<ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADevice> VirtualMFADevice { get; set; }
            public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADevice : TeaModel {
                public string SerialNumber { get; set; }
                public ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser User { get; set; }
                public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser : TeaModel {
                    [NameInMap("UserPrincipalName")]
                    [Validation(Required=false)]
                    public string UserPrincipalName { get; set; }

                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }
                public string ActivateDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}
