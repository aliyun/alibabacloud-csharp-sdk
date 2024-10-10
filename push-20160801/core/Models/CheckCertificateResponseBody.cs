// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckCertificateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Android")]
        [Validation(Required=false)]
        public bool? Android { get; set; }

        [NameInMap("DevelopmentCertInfo")]
        [Validation(Required=false)]
        public CheckCertificateResponseBodyDevelopmentCertInfo DevelopmentCertInfo { get; set; }
        public class CheckCertificateResponseBodyDevelopmentCertInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1470024000000</para>
            /// </summary>
            [NameInMap("ExipreTime")]
            [Validation(Required=false)]
            public long? ExipreTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXPIRED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IOS")]
        [Validation(Required=false)]
        public bool? IOS { get; set; }

        [NameInMap("ProductionCertInfo")]
        [Validation(Required=false)]
        public CheckCertificateResponseBodyProductionCertInfo ProductionCertInfo { get; set; }
        public class CheckCertificateResponseBodyProductionCertInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1764561600000</para>
            /// </summary>
            [NameInMap("ExipreTime")]
            [Validation(Required=false)]
            public long? ExipreTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
