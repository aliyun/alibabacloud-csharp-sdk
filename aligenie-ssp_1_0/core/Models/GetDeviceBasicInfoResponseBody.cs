// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code returned. A value of 200 indicates that the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Return result of invoking this API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed information returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetDeviceBasicInfoResponseBodyResult Result { get; set; }
        public class GetDeviceBasicInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Firmware version of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.3</para>
            /// </summary>
            [NameInMap("FirmwareVersion")]
            [Validation(Required=false)]
            public string FirmwareVersion { get; set; }

            /// <summary>
            /// <para>MAC address of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b4:xx:xx:xx:65:2b</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>Name of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>我的设备</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>SN information of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200xxx048</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

    }

}
