// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectCovid19CadResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectCovid19CadResponseBodyData Data { get; set; }
        public class DetectCovid19CadResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9387283236994219</para>
            /// </summary>
            [NameInMap("LesionRatio")]
            [Validation(Required=false)]
            public string LesionRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-med-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/covid19-dcm/unspecified/2020032702/1b1e1018-6fcf-11ea-8fa1-d20b34387541.nii.gz?Expires=1585276394&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=%2F1LNGWJUqvY0VRYGgg8Ldtb3BF">http://algo-app-aic-med-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/covid19-dcm/unspecified/2020032702/1b1e1018-6fcf-11ea-8fa1-d20b34387541.nii.gz?Expires=1585276394&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=%2F1LNGWJUqvY0VRYGgg8Ldtb3BF</a>****</para>
            /// </summary>
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4.062644e-06</para>
            /// </summary>
            [NameInMap("NewProbability")]
            [Validation(Required=false)]
            public string NewProbability { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7230905</para>
            /// </summary>
            [NameInMap("NormalProbability")]
            [Validation(Required=false)]
            public string NormalProbability { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.27690542</para>
            /// </summary>
            [NameInMap("OtherProbability")]
            [Validation(Required=false)]
            public string OtherProbability { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7CB9B663-3EF8-4C9C-A464-FDA2B5F1E3A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
