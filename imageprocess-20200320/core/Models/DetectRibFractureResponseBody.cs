// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectRibFractureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectRibFractureResponseBodyData Data { get; set; }
        public class DetectRibFractureResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<DetectRibFractureResponseBodyDataDetections> Detections { get; set; }
            public class DetectRibFractureResponseBodyDataDetections : TeaModel {
                [NameInMap("CoordinateImage")]
                [Validation(Required=false)]
                public List<int?> CoordinateImage { get; set; }

                [NameInMap("Coordinates")]
                [Validation(Required=false)]
                public List<int?> Coordinates { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("FracSOPInstanceUID")]
                [Validation(Required=false)]
                public string FracSOPInstanceUID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FractureCategory")]
                [Validation(Required=false)]
                public string FractureCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.7916666666666667</para>
                /// </summary>
                [NameInMap("FractureConfidence")]
                [Validation(Required=false)]
                public float? FractureConfidence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FractureId")]
                [Validation(Required=false)]
                public int? FractureId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>L4</para>
                /// </summary>
                [NameInMap("FractureLocation")]
                [Validation(Required=false)]
                public string FractureLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FractureSegment")]
                [Validation(Required=false)]
                public long? FractureSegment { get; set; }

            }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<float?> Origin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/detect-rib-fracture/local_test/2020-12-22/result-D5CD101C-F8E5-43CA-9E99-44C783B8F8BE.tar.gz?Expires=1608631727&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=d6c32E1IB4b7Ayo1lpjs%2Bq3Ylv">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/detect-rib-fracture/local_test/2020-12-22/result-D5CD101C-F8E5-43CA-9E99-44C783B8F8BE.tar.gz?Expires=1608631727&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=d6c32E1IB4b7Ayo1lpjs%2Bq3Ylv</a>****</para>
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
        /// <para>5C695B5D-41A6-4202-8BF7-E647698678DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
