// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class CalcCACSResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CalcCACSResponseBodyData Data { get; set; }
        public class CalcCACSResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<CalcCACSResponseBodyDataDetections> Detections { get; set; }
            public class CalcCACSResponseBodyDataDetections : TeaModel {
                [NameInMap("CalciumCenter")]
                [Validation(Required=false)]
                public List<long?> CalciumCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CalciumId")]
                [Validation(Required=false)]
                public long? CalciumId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19.22474</para>
                /// </summary>
                [NameInMap("CalciumScore")]
                [Validation(Required=false)]
                public float? CalciumScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>28.837109</para>
                /// </summary>
                [NameInMap("CalciumVolume")]
                [Validation(Required=false)]
                public float? CalciumVolume { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-cacs/2020-09-29/2020-09-29-11%3A07%3A41-D74FE0DF-8F80-41EB-B08B-2E67053587EC.tar.gz?Expires=1601350661&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=iB16ms28Y5mzB11ghYUd7upCi4">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-cacs/2020-09-29/2020-09-29-11%3A07%3A41-D74FE0DF-8F80-41EB-B08B-2E67053587EC.tar.gz?Expires=1601350661&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=iB16ms28Y5mzB11ghYUd7upCi4</a>****</para>
            /// </summary>
            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>117.61</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111.96</para>
            /// </summary>
            [NameInMap("VolumeScore")]
            [Validation(Required=false)]
            public string VolumeScore { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6797D285-9290-4FBB-9742-AA1E286EF3B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
