// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class EvaluateCertificateQualityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EvaluateCertificateQualityResponseBodyData Data { get; set; }
        public class EvaluateCertificateQualityResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<EvaluateCertificateQualityResponseBodyDataElements> Elements { get; set; }
            public class EvaluateCertificateQualityResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Pass")]
                [Validation(Required=false)]
                public string Pass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.06514739990234375</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>lackoffront</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>656318DC-3856-43E3-9147-859532721AD6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
