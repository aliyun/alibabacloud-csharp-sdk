// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GenRealPersonVerificationTokenResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenRealPersonVerificationTokenResponseBodyData Data { get; set; }
        public class GenRealPersonVerificationTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>9fca3791c158a479ead9f2ba65ab3XXX</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A31006F2-22E7-4538-93BB-DE6B563643EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
