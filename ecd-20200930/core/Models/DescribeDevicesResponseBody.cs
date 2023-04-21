// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDevicesResponseBody : TeaModel {
        /// <summary>
        /// Details of the devices that are returned.
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribeDevicesResponseBodyDevices> Devices { get; set; }
        public class DescribeDevicesResponseBodyDevices : TeaModel {
            /// <summary>
            /// The ID of the device.
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// The users who are bound to the device.
            /// </summary>
            [NameInMap("EndUserList")]
            [Validation(Required=false)]
            public List<DescribeDevicesResponseBodyDevicesEndUserList> EndUserList { get; set; }
            public class DescribeDevicesResponseBodyDevicesEndUserList : TeaModel {
                /// <summary>
                /// The address of the AD workspace.
                /// </summary>
                [NameInMap("AdDomain")]
                [Validation(Required=false)]
                public string AdDomain { get; set; }

                /// <summary>
                /// The ID of the workspace.
                /// </summary>
                [NameInMap("DirectoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// The type of the account.
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
