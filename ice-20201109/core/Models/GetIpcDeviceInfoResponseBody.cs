// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetIpcDeviceInfoResponseBody : TeaModel {
        [NameInMap("DeviceInfos")]
        [Validation(Required=false)]
        public List<GetIpcDeviceInfoResponseBodyDeviceInfos> DeviceInfos { get; set; }
        public class GetIpcDeviceInfoResponseBodyDeviceInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>understand</para>
            /// </summary>
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public string Capability { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d123</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-02-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>78</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
