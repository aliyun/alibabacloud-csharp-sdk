// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenGCResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenGCResponseBodyData Data { get; set; }
        public class ScreenGCResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenGCResponseBodyDataLesion Lesion { get; set; }
            public class ScreenGCResponseBodyDataLesion : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5.86</para>
                /// </summary>
                [NameInMap("GCVolume")]
                [Validation(Required=false)]
                public string GCVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen_gc/gc_11949981_stomach.nii.gz?Expires=1680678697&OSSAccessKeyId=LTAI4GC2dJzdf8ZvnC16****&Signature=EpKCTEPipWO0AiB3Uip85c%2BuMg">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen_gc/gc_11949981_stomach.nii.gz?Expires=1680678697&amp;OSSAccessKeyId=LTAI4GC2dJzdf8ZvnC16****&amp;Signature=EpKCTEPipWO0AiB3Uip85c%2BuMg</a>****</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00</para>
                /// </summary>
                [NameInMap("NonGCVolume")]
                [Validation(Required=false)]
                public string NonGCVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;0.1467&quot;, &quot;0.8533&quot;, &quot;0.0000&quot;]</para>
                /// </summary>
                [NameInMap("Probabilities")]
                [Validation(Required=false)]
                public string Probabilities { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>508.79</para>
                /// </summary>
                [NameInMap("StomachVolume")]
                [Validation(Required=false)]
                public string StomachVolume { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9B65AC8E-311A-1ED1-BBE6-6AA6D35D31A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
