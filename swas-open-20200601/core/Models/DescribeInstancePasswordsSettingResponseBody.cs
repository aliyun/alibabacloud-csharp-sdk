// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInstancePasswordsSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a logon password is set for the simple application server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InstancePasswordSetting")]
        [Validation(Required=false)]
        public bool? InstancePasswordSetting { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether a VNC connection password is set for the simple application server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VncPasswordSetting")]
        [Validation(Required=false)]
        public bool? VncPasswordSetting { get; set; }

    }

}
