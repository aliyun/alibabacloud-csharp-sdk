// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ActivateEdgeMobileAgentRequest : TeaModel {
        /// <summary>
        /// <para>The device class. Valid values: BOX, PHONE, PAD, and OTHER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOX</para>
        /// </summary>
        [NameInMap("DeviceClass")]
        [Validation(Required=false)]
        public string DeviceClass { get; set; }

        /// <summary>
        /// <para>The unique identifier of the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sn-0001eevqa6jeapl*****</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The extended metadata of the device. The value is a JSON string that contains information such as fingerprint, deviceModel, and firmwareVersion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;frmwareVersion&quot;: &quot;1.0.0&quot;}</para>
        /// </summary>
        [NameInMap("DeviceMeta")]
        [Validation(Required=false)]
        public string DeviceMeta { get; set; }

        /// <summary>
        /// <para>The license key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lic-ez197xvdf0j5eo0*****</para>
        /// </summary>
        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

    }

}
