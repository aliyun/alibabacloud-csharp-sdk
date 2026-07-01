// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetIpcDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>List of device identity information.</para>
        /// </summary>
        [NameInMap("DeviceInfos")]
        [Validation(Required=false)]
        public List<GetIpcDeviceInfoResponseBodyDeviceInfos> DeviceInfos { get; set; }
        public class GetIpcDeviceInfoResponseBodyDeviceInfos : TeaModel {
            /// <summary>
            /// <para>Capability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>understand: understanding</para>
            /// </description></item>
            /// <item><description><para>understand-reid: understanding with reid</para>
            /// </description></item>
            /// <item><description><para>search: search</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>understand</para>
            /// </summary>
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public string Capability { get; set; }

            /// <summary>
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d123</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Expiration Time. UTC time in the format yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-02-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
