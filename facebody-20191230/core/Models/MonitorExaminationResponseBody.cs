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
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.28805577754974365</para>
            /// </summary>
            [NameInMap("ChatScore")]
            [Validation(Required=false)]
            public float? ChatScore { get; set; }

            [NameInMap("FaceInfo")]
            [Validation(Required=false)]
            public MonitorExaminationResponseBodyDataFaceInfo FaceInfo { get; set; }
            public class MonitorExaminationResponseBodyDataFaceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Completeness")]
                [Validation(Required=false)]
                public float? Completeness { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                [NameInMap("Pose")]
                [Validation(Required=false)]
                public MonitorExaminationResponseBodyDataFaceInfoPose Pose { get; set; }
                public class MonitorExaminationResponseBodyDataFaceInfoPose : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-0.9185499548912048</para>
                    /// </summary>
                    [NameInMap("Pitch")]
                    [Validation(Required=false)]
                    public float? Pitch { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-0.18541647493839264</para>
                    /// </summary>
                    [NameInMap("Roll")]
                    [Validation(Required=false)]
                    public float? Roll { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8.095342636108398</para>
                    /// </summary>
                    [NameInMap("Yaw")]
                    [Validation(Required=false)]
                    public float? Yaw { get; set; }

                }

            }

            [NameInMap("PersonInfo")]
            [Validation(Required=false)]
            public MonitorExaminationResponseBodyDataPersonInfo PersonInfo { get; set; }
            public class MonitorExaminationResponseBodyDataPersonInfo : TeaModel {
                [NameInMap("CellPhone")]
                [Validation(Required=false)]
                public MonitorExaminationResponseBodyDataPersonInfoCellPhone CellPhone { get; set; }
                public class MonitorExaminationResponseBodyDataPersonInfoCellPhone : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.39076218008995056</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                }

                [NameInMap("EarPhone")]
                [Validation(Required=false)]
                public MonitorExaminationResponseBodyDataPersonInfoEarPhone EarPhone { get; set; }
                public class MonitorExaminationResponseBodyDataPersonInfoEarPhone : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.7980290651321411</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PersonNumber")]
                [Validation(Required=false)]
                public long? PersonNumber { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0F6EB94-73B6-4CB8-B266-22D2F221C475</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
