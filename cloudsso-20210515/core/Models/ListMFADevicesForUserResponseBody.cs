// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListMFADevicesForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The MFA devices.</para>
        /// </summary>
        [NameInMap("MFADevices")]
        [Validation(Required=false)]
        public List<ListMFADevicesForUserResponseBodyMFADevices> MFADevices { get; set; }
        public class ListMFADevicesForUserResponseBodyMFADevices : TeaModel {
            /// <summary>
            /// <para>The ID of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mfa-00ujhet8pycljj7j****</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>The name of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice-MFA1</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>The type of the MFA device. The value is fixed as TOTP, which indicates a virtual MFA device. Virtual MFA devices are based on the Time-based One-time Password (TOTP) algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TOTP</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The time when the MFA device was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-29T09:14:06Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00q8wbq42wiltcrk****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B9982ED-FD0D-5622-8EA0-7B768685DCE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of MFA devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
