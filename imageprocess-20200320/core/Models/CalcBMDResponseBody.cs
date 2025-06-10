// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class CalcBMDResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CalcBMDResponseBodyData Data { get; set; }
        public class CalcBMDResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<CalcBMDResponseBodyDataDetections> Detections { get; set; }
            public class CalcBMDResponseBodyDataDetections : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.78</para>
                /// </summary>
                [NameInMap("VertBMD")]
                [Validation(Required=false)]
                public float? VertBMD { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NaN</para>
                /// </summary>
                [NameInMap("VertCategory")]
                [Validation(Required=false)]
                public float? VertCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>L1</para>
                /// </summary>
                [NameInMap("VertId")]
                [Validation(Required=false)]
                public string VertId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-2.5</para>
                /// </summary>
                [NameInMap("VertTScore")]
                [Validation(Required=false)]
                public float? VertTScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NaN</para>
                /// </summary>
                [NameInMap("VertZScore")]
                [Validation(Required=false)]
                public float? VertZScore { get; set; }

            }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<float?> Origin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-bmd/local_test/2023-03-31/7772ECE3-22A7-193F-81B4-B0D6A02B5DAF-result.tgz?Expires=1680486509&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=GWi%2BhCCtamefKVYiS9oZJduswH">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-bmd/local_test/2023-03-31/7772ECE3-22A7-193F-81B4-B0D6A02B5DAF-result.tgz?Expires=1680486509&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=GWi%2BhCCtamefKVYiS9oZJduswH</a>****</para>
            /// </summary>
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

            [NameInMap("Spacing")]
            [Validation(Required=false)]
            public List<float?> Spacing { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B48DECE6-29FE-1967-92F1-2E072873851A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
