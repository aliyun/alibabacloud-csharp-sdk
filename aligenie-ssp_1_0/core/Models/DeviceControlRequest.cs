// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class DeviceControlRequest : TeaModel {
        /// <summary>
        /// <para>Input parameters for volume control</para>
        /// </summary>
        [NameInMap("ControlRequest")]
        [Validation(Required=false)]
        public DeviceControlRequestControlRequest ControlRequest { get; set; }
        public class DeviceControlRequestControlRequest : TeaModel {
            /// <summary>
            /// <para>Indicates whether mute is enabled. If this field is set to true, you must also specify the volume value as 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Muted")]
            [Validation(Required=false)]
            public bool? Muted { get; set; }

            /// <summary>
            /// <para>Target volume value</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <para>List of device ID information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public DeviceControlRequestDeviceInfo DeviceInfo { get; set; }
        public class DeviceControlRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type. Enter the Project ID of the project where the product resides. You can View this in the Tmall Genie AI platform console.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding Type. Enter PROJECT_ID here.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID. Enter the value of deviceOpenId or deviceUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The type of Device ID:<br>OPEN_ID: The default Device ID identity.<br>UNION_ID: The organization-dimension Device ID identity. You must request an organization in advance on the Open Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID of the device. Required if IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1*****2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
