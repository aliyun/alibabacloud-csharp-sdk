// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class MonitorExaminationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MonitorExaminationResponseBodyData Data { get; set; }
        public class MonitorExaminationResponseBodyData : TeaModel {
            [NameInMap("ChatScore")]
            [Validation(Required=false)]
            public float? ChatScore { get; set; }
            [NameInMap("FaceInfo")]
            [Validation(Required=false)]
            public MonitorExaminationResponseBodyDataFaceInfo FaceInfo { get; set; }
            public class MonitorExaminationResponseBodyDataFaceInfo : TeaModel {
                [NameInMap("Completeness")]
                [Validation(Required=false)]
                public float? Completeness { get; set; }

                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                [NameInMap("Pose")]
                [Validation(Required=false)]
                public MonitorExaminationResponseBodyDataFaceInfoPose Pose { get; set; }
                public class MonitorExaminationResponseBodyDataFaceInfoPose : TeaModel {
                    [NameInMap("Pitch")]
                    [Validation(Required=false)]
                    public float? Pitch { get; set; }
                    [NameInMap("Roll")]
                    [Validation(Required=false)]
                    public float? Roll { get; set; }
                    [NameInMap("Yaw")]
                    [Validation(Required=false)]
                    public float? Yaw { get; set; }
                };

            }
            [NameInMap("PersonInfo")]
            [Validation(Required=false)]
            public MonitorExaminationResponseBodyDataPersonInfo PersonInfo { get; set; }
            public class MonitorExaminationResponseBodyDataPersonInfo : TeaModel {
                [NameInMap("CellPhone")]
                [Validation(Required=false)]
                public MonitorExaminationResponseBodyDataPersonInfoCellPhone CellPhone { get; set; }
                public class MonitorExaminationResponseBodyDataPersonInfoCellPhone : TeaModel {
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }
                };

                [NameInMap("EarPhone")]
                [Validation(Required=false)]
                public MonitorExaminationResponseBodyDataPersonInfoEarPhone EarPhone { get; set; }
                public class MonitorExaminationResponseBodyDataPersonInfoEarPhone : TeaModel {
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }
                };

                [NameInMap("PersonNumber")]
                [Validation(Required=false)]
                public long? PersonNumber { get; set; }

            }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
