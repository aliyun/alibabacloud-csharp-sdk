// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class GetDeviceCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>Certificate details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceCertificateResponseBodyData Data { get; set; }
        public class GetDeviceCertificateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The SN serial number of the CA certificate to which the device certificate belongs, used to uniquely identify a CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00f26900ba87******</para>
            /// </summary>
            [NameInMap("CaSn")]
            [Validation(Required=false)]
            public string CaSn { get; set; }

            /// <summary>
            /// <para>Content of the device certificate.</para>
            /// <para> represents a new line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN DEVICECERTIFICATE-----\nMIIDuzCCAqdGVzdC5jbi1xaW5n******\n-----END DEVICECERTIFICATE-----</para>
            /// </summary>
            [NameInMap("DeviceContent")]
            [Validation(Required=false)]
            public string DeviceContent { get; set; }

            /// <summary>
            /// <para>Name of the device certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt_device</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>The SN serial number of the device certificate, used to uniquely identify a device certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>356217374433******</para>
            /// </summary>
            [NameInMap("DeviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            /// <summary>
            /// <para>The status of the device certificate. The values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Indicates that the certificate is in an inactive state. - <b>1</b>: Indicates that the certificate is in an active state.<remarks>
            /// <para>After the device certificate is registered, it is in an active state by default.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The start time when the device certificate becomes effective. The format is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1654137303000</para>
            /// </summary>
            [NameInMap("ValidBegin")]
            [Validation(Required=false)]
            public string ValidBegin { get; set; }

            /// <summary>
            /// <para>The end time when the device certificate becomes effective. The format is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1969497303000</para>
            /// </summary>
            [NameInMap("ValidEnd")]
            [Validation(Required=false)]
            public string ValidEnd { get; set; }

        }

        /// <summary>
        /// <para>Public parameters, each request ID is unique and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
