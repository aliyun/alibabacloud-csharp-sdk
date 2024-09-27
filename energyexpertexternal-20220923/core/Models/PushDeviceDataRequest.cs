// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class PushDeviceDataRequest : TeaModel {
        /// <summary>
        /// <para>The type of the device. <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/Deviceappendixes-en.pdf">View device type definitions</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>List of devices to which data is pushed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("devices")]
        [Validation(Required=false)]
        public List<PushDeviceDataRequestDevices> Devices { get; set; }
        public class PushDeviceDataRequestDevices : TeaModel {
            /// <summary>
            /// <para>Measuring point information To avoid accuracy problems, the measurement point data is uniformly transmitted to the string. The function of missing required fields cannot be used normally. Some functions may be affected due to the lack of recommend fields. For details, please refer to the notes of equipment measuring points in the appendix. <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/Deviceappendixes-en.pdf">Reference Point Definition</a></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///             &quot;dp_imp&quot;: &quot;329.0&quot;,
            ///             &quot;F&quot;: &quot;148.0&quot;,
            ///             &quot;eq_imp&quot;: &quot;363.0&quot;,
            ///             &quot;Ep_imp_1&quot;: &quot;128.0&quot;,
            ///             &quot;Ep_imp_2&quot;: &quot;157.0&quot;,
            ///             &quot;Ua&quot;: &quot;226.0&quot;,
            ///             &quot;Ub&quot;: &quot;285.0&quot;,
            ///             &quot;Ep_imp&quot;: &quot;325.0&quot;,
            ///             &quot;Uc&quot;: &quot;342.0&quot;,
            ///             &quot;Ep_imp_3&quot;: &quot;109.0&quot;,
            ///             &quot;Ep_imp_4&quot;: &quot;94.0&quot;,
            ///             &quot;P&quot;: &quot;514.0&quot;,
            ///             &quot;Pa&quot;: &quot;443.0&quot;,
            ///             &quot;Q&quot;: &quot;265.0&quot;,
            ///             &quot;dp_exp&quot;: &quot;261.0&quot;,
            ///             &quot;eq_exp&quot;: &quot;399.0&quot;,
            ///             &quot;COSQ&quot;: &quot;223.0&quot;,
            ///             &quot;Ia&quot;: &quot;240.0&quot;,
            ///             &quot;Ib&quot;: &quot;216.0&quot;,
            ///             &quot;Ic&quot;: &quot;229.0&quot;,
            ///             &quot;Ep_exp&quot;: &quot;115.0&quot;,
            ///             &quot;VdisPer&quot;: &quot;120.0&quot;
            ///         }</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <para>If the deviceType parameter is set to 12, 13, or 17, you must set the system_id parameter. The field name is still device_id. If the deviceType parameter is set to 15 or 16, no Other situations will be transmitted.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>device_code_xxx</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Data generation time of measuring point.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08 18:40:00</para>
            /// </summary>
            [NameInMap("recordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

        }

    }

}
