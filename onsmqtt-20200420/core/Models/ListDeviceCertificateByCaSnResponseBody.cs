// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListDeviceCertificateByCaSnResponseBody : TeaModel {
        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceCertificateByCaSnResponseBodyData Data { get; set; }
        public class ListDeviceCertificateByCaSnResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details of the device certificate.</para>
            /// </summary>
            [NameInMap("DeviceCertificateVOS")]
            [Validation(Required=false)]
            public List<ListDeviceCertificateByCaSnResponseBodyDataDeviceCertificateVOS> DeviceCertificateVOS { get; set; }
            public class ListDeviceCertificateByCaSnResponseBodyDataDeviceCertificateVOS : TeaModel {
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
                /// <item><description>0: indicates that the certificate is in an inactive state. </description></item>
                /// <item><description>1: indicates that the certificate is in an active state.</description></item>
                /// </list>
                /// <para>After the device certificate is registered, it is in an active state by default.</para>
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
            /// <para>The current page number of the returned query records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The maximum number of results to display per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
