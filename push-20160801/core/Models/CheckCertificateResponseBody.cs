// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the AppKey belongs to an Android app:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Android")]
        [Validation(Required=false)]
        public bool? Android { get; set; }

        /// <summary>
        /// <para>The information about the certificate for the development or sandbox environment.</para>
        /// </summary>
        [NameInMap("DevelopmentCertInfo")]
        [Validation(Required=false)]
        public CheckCertificateResponseBodyDevelopmentCertInfo DevelopmentCertInfo { get; set; }
        public class CheckCertificateResponseBodyDevelopmentCertInfo : TeaModel {
            /// <summary>
            /// <para>The expiration time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1470024000000</para>
            /// </summary>
            [NameInMap("ExipreTime")]
            [Validation(Required=false)]
            public long? ExipreTime { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>EXPIRED</b>: The certificate is expired.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_CONFIGURED</b>: The certificate is not configured.</para>
            /// </description></item>
            /// <item><description><para><b>NO_PASSWORD</b>: The password for the certificate is not configured.</para>
            /// </description></item>
            /// <item><description><para><b>OK</b>: The certificate is normal.</para>
            /// </description></item>
            /// <item><description><para><b>REVOKED</b>: The certificate is revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXPIRED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the AppKey belongs to an iOS app:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IOS")]
        [Validation(Required=false)]
        public bool? IOS { get; set; }

        /// <summary>
        /// <para>The information about the certificate for the production environment.</para>
        /// </summary>
        [NameInMap("ProductionCertInfo")]
        [Validation(Required=false)]
        public CheckCertificateResponseBodyProductionCertInfo ProductionCertInfo { get; set; }
        public class CheckCertificateResponseBodyProductionCertInfo : TeaModel {
            /// <summary>
            /// <para>The expiration time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1764561600000</para>
            /// </summary>
            [NameInMap("ExipreTime")]
            [Validation(Required=false)]
            public long? ExipreTime { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>EXPIRED</b>: The certificate is expired.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_CONFIGURED</b>: The certificate is not configured.</para>
            /// </description></item>
            /// <item><description><para><b>NO_PASSWORD</b>: The password for the certificate is not configured.</para>
            /// </description></item>
            /// <item><description><para><b>OK</b>: The certificate is normal.</para>
            /// </description></item>
            /// <item><description><para><b>REVOKED</b>: The certificate is revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
