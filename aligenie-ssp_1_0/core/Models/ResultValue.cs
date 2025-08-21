// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ResultValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A963*0158</para>
        /// </summary>
        [NameInMap("DeviceOpenId")]
        [Validation(Required=false)]
        public string DeviceOpenId { get; set; }

        [NameInMap("DeviceUnionIds")]
        [Validation(Required=false)]
        public List<ResultValueDeviceUnionIds> DeviceUnionIds { get; set; }
        public class ResultValueDeviceUnionIds : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1553*B0C3</para>
            /// </summary>
            [NameInMap("DeviceUnionId")]
            [Validation(Required=false)]
            public string DeviceUnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我的设备</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0.3</para>
        /// </summary>
        [NameInMap("FirmwareVersion")]
        [Validation(Required=false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b4:xx:xx:xx:65:2b</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1200xx048</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
