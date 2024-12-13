// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListCaCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCaCertificateResponseBodyData Data { get; set; }
        public class ListCaCertificateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details of the CA certificate</para>
            /// </summary>
            [NameInMap("CaCertificateVOS")]
            [Validation(Required=false)]
            public List<ListCaCertificateResponseBodyDataCaCertificateVOS> CaCertificateVOS { get; set; }
            public class ListCaCertificateResponseBodyDataCaCertificateVOS : TeaModel {
                /// <summary>
                /// <para>Content of the CA certificate. </para>
                /// <remarks>
                /// <para>\n represents a new line.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE-----\nMIIDuzCCAqdGVzdC5jbi1xaW5n******\n-----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("CaContent")]
                [Validation(Required=false)]
                public string CaContent { get; set; }

                /// <summary>
                /// <para>Name of the CA certificate</para>
                /// 
                /// <b>Example:</b>
                /// <para>mqtt_ca</para>
                /// </summary>
                [NameInMap("CaName")]
                [Validation(Required=false)]
                public string CaName { get; set; }

                /// <summary>
                /// <para>Registration code of the CA certificate</para>
                /// 
                /// <b>Example:</b>
                /// <para>13274673-8f90-4630-bea1-9cccb25756ad2089******</para>
                /// </summary>
                [NameInMap("RegistrationCode")]
                [Validation(Required=false)]
                public string RegistrationCode { get; set; }

                /// <summary>
                /// <para>SN serial number of the CA certificate</para>
                /// 
                /// <b>Example:</b>
                /// <para>007269004887******</para>
                /// </summary>
                [NameInMap("Sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                /// <summary>
                /// <para>The status of the CA certificate. The values are as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Indicates that the certificate is in an inactive state. - <b>1</b>: Indicates that the certificate is in an active state.<remarks>
                /// <para>After the CA certificate is registered, it is in an active state by default.</para>
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
                /// <para>The start time when the CA certificate becomes effective. The format is a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1654137303000</para>
                /// </summary>
                [NameInMap("ValidBegin")]
                [Validation(Required=false)]
                public string ValidBegin { get; set; }

                /// <summary>
                /// <para>The end time when the CA certificate becomes effective. The format is a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1969497303000</para>
                /// </summary>
                [NameInMap("ValidEnd")]
                [Validation(Required=false)]
                public string ValidEnd { get; set; }

                /// <summary>
                /// <para>Verify the content of the certificate. </para>
                /// <remarks>
                /// <para>\n represents a new line.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE-----\nMIID/DCCAu+Y5sRMpp9tnd+4s******\n-----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("VerificationContent")]
                [Validation(Required=false)]
                public string VerificationContent { get; set; }

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
            /// <para>Maximum number of pages in the query result.</para>
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
