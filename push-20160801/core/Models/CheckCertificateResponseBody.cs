// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the AppKey represents an Android app:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Android")]
        [Validation(Required=false)]
        public bool? Android { get; set; }

        /// <summary>
        /// <para>The certificate information for accessing the development or sandbox environment.</para>
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
            /// <para>The certificate status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EXPIRED</b>: The certificate has expired.</description></item>
            /// <item><description><b>NOT_CONFIGURED</b>: The certificate is not configured.</description></item>
            /// <item><description><b>NO_PASSWORD</b>: The password is not configured.</description></item>
            /// <item><description><b>OK</b>: The certificate is normal.</description></item>
            /// <item><description><b>REVOKED</b>: The certificate is revoked.</description></item>
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
        /// <para>Indicates whether the AppKey represents an iOS app:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IOS")]
        [Validation(Required=false)]
        public bool? IOS { get; set; }

        /// <summary>
        /// <para>The certificate information for accessing the production environment.</para>
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
            /// <para>The certificate status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EXPIRED</b>: The certificate has expired.</description></item>
            /// <item><description><b>NOT_CONFIGURED</b>: The certificate is not configured.</description></item>
            /// <item><description><b>NO_PASSWORD</b>: The password is not configured.</description></item>
            /// <item><description><b>OK</b>: The certificate is normal.</description></item>
            /// <item><description><b>REVOKED</b>: The certificate is revoked.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
