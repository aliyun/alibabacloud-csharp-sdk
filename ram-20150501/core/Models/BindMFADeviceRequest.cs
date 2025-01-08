// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class BindMFADeviceRequest : TeaModel {
        /// <summary>
        /// <para>The first authentication code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11****</para>
        /// </summary>
        [NameInMap("AuthenticationCode1")]
        [Validation(Required=false)]
        public string AuthenticationCode1 { get; set; }

        /// <summary>
        /// <para>The second authentication code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33****</para>
        /// </summary>
        [NameInMap("AuthenticationCode2")]
        [Validation(Required=false)]
        public string AuthenticationCode2 { get; set; }

        /// <summary>
        /// <para>The serial number of the MFA device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:mfa/device002</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The name of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangq****</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
