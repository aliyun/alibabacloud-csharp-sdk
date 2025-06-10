// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenCRCResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenCRCResponseBodyData Data { get; set; }
        public class ScreenCRCResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenCRCResponseBodyDataLesion Lesion { get; set; }
            public class ScreenCRCResponseBodyDataLesion : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7.83</para>
                /// </summary>
                [NameInMap("CRCVolume")]
                [Validation(Required=false)]
                public string CRCVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>255.93</para>
                /// </summary>
                [NameInMap("ColorectumVolume")]
                [Validation(Required=false)]
                public string ColorectumVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen_crc/crc_case2_pre.nii.gz?Expires=1680766116&OSSAccessKeyId=LTAI4GC2dJzdf8ZvnC16MFC7&Signature=9n9C%2B2MnyvLwAC%2FwFyxgY">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen_crc/crc_case2_pre.nii.gz?Expires=1680766116&amp;OSSAccessKeyId=LTAI4GC2dJzdf8ZvnC16MFC7&amp;Signature=9n9C%2B2MnyvLwAC%2FwFyxgY</a>********</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0779, 0.9221</para>
                /// </summary>
                [NameInMap("Probabilities")]
                [Validation(Required=false)]
                public string Probabilities { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39C848F7-D814-1A06-AE0D-AFC706B9700F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
