// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RegisterDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The device ID. Any string can be used, and there are no specific format requirements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-device</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The device password. The SIP device uses this password for authentication during registration. Store this password securely.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>A JSON string that contains an array of agent IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;user-test@ccc-test&quot;]</para>
        /// </summary>
        [NameInMap("UserIdListJson")]
        [Validation(Required=false)]
        public string UserIdListJson { get; set; }

    }

}
