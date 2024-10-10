// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckDevicesResponseBody : TeaModel {
        [NameInMap("DeviceCheckInfos")]
        [Validation(Required=false)]
        public CheckDevicesResponseBodyDeviceCheckInfos DeviceCheckInfos { get; set; }
        public class CheckDevicesResponseBodyDeviceCheckInfos : TeaModel {
            [NameInMap("DeviceCheckInfo")]
            [Validation(Required=false)]
            public List<CheckDevicesResponseBodyDeviceCheckInfosDeviceCheckInfo> DeviceCheckInfo { get; set; }
            public class CheckDevicesResponseBodyDeviceCheckInfosDeviceCheckInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ae296f3b04a58a05b30c95f****</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
