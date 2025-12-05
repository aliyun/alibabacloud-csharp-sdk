// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ActiveAiRtcLicenseRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iU1IeJech7***</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device-***</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The batch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17712***</para>
        /// </summary>
        [NameInMap("LicenseItemId")]
        [Validation(Required=false)]
        public string LicenseItemId { get; set; }

    }

}
