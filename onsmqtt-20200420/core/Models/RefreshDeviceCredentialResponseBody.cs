// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RefreshDeviceCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The access credential of the device.</para>
        /// </summary>
        [NameInMap("DeviceCredential")]
        [Validation(Required=false)]
        public RefreshDeviceCredentialResponseBodyDeviceCredential DeviceCredential { get; set; }
        public class RefreshDeviceCredentialResponseBodyDeviceCredential : TeaModel {
            /// <summary>
            /// <para>The client ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test@@@test</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the access credential of the device was created. The value of this parameter is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605541382000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The AccessKey ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC.Z5fXh9sRRVufyLi6wo****</para>
            /// </summary>
            [NameInMap("DeviceAccessKeyId")]
            [Validation(Required=false)]
            public string DeviceAccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC.BJMkn4eMQJK2vaApTS****</para>
            /// </summary>
            [NameInMap("DeviceAccessKeySecret")]
            [Validation(Required=false)]
            public string DeviceAccessKeySecret { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraMQ for MQTT instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>post-cn-0pp12gl****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the access credential of the device was last updated. The value of this parameter is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605541382000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4581CCF-62AF-44D9-B5B4-D1DBDC0F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
