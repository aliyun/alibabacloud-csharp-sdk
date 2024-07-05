// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitSnapshotJobResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the snapshot job.
        /// </summary>
        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public SubmitSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class SubmitSnapshotJobResponseBodySnapshotJob : TeaModel {
            /// <summary>
            /// The error code returned if the job fails. This parameter is not returned if the job is successful.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The number of snapshots that are captured.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the snapshot job.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The information about the job input.
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobInput Input { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobInput : TeaModel {
                /// <summary>
                /// The OSS bucket that stores the object.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// The region in which the OSS bucket resides.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The OSS object that is used as the input file.
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                /// <summary>
                /// The ARN of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

            }

            /// <summary>
            /// The message sent by MNS to notify the user of the job result.
            /// </summary>
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobMNSMessageResult : TeaModel {
                /// <summary>
                /// The error code returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The ID of the message. This parameter is not returned if the job fails.
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

            }

            /// <summary>
            /// The error message returned if the job fails. This parameter is not returned if the job is successful.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the MPS queue to which the snapshot job is submitted.
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// The snapshot configurations.
            /// </summary>
            [NameInMap("SnapshotConfig")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfig SnapshotConfig { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfig : TeaModel {
                /// <summary>
                /// The type of the snapshot. Default value: **Normal**. Valid values:
                /// 
                /// *   **normal**: normal frames.
                /// *   **intra**: I-frames (keyframes).
                /// 
                /// > If the FrameType parameter is set to intra in the request, only keyframes are captured. If no keyframe is found at the specified point in time, the keyframe closest to the specified point in time is captured. Keyframes are captured faster than normal frames if the same snapshot rules are applied.
                /// </summary>
                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                /// <summary>
                /// The height of the output snapshot.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The interval for capturing snapshots.
                /// 
                /// *   If this parameter is specified in the request, snapshots are captured at intervals. The value must be greater than 0 in the request.
                /// *   Unit: seconds.
                /// *   Default value: **10**.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// The number of snapshots. If the Num parameter is set in the request, snapshots are captured at intervals.
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public string Num { get; set; }

                /// <summary>
                /// The information about the output file of the snapshot job.
                /// </summary>
                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigOutputFile OutputFile { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigOutputFile : TeaModel {
                    /// <summary>
                    /// The OSS bucket that stores the output snapshot.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The OSS region in which the OSS bucket for storing the output snapshot resides.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The OSS object that is generated as the output file of the snapshot job.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    /// <summary>
                    /// The Alibaba Cloud Resource Name (ARN) of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                /// <summary>
                /// The tiling configurations.
                /// </summary>
                [NameInMap("TileOut")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOut TileOut { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOut : TeaModel {
                    /// <summary>
                    /// The height of a single image. The default value is the height of the output snapshot.
                    /// </summary>
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public string CellHeight { get; set; }

                    /// <summary>
                    /// The step for selecting a single image.
                    /// </summary>
                    [NameInMap("CellSelStep")]
                    [Validation(Required=false)]
                    public string CellSelStep { get; set; }

                    /// <summary>
                    /// The width of a single image. The default value is the width of the output snapshot.
                    /// </summary>
                    [NameInMap("CellWidth")]
                    [Validation(Required=false)]
                    public string CellWidth { get; set; }

                    /// <summary>
                    /// The background color.
                    /// 
                    /// *   Default value: **black**.
                    /// *   You can set the Color parameter to a **color keyword** or **random** in the request.
                    /// 
                    /// > If you want to set the background color to black, you can specify the color keyword in one of the following three formats: Black, black, and #000000.
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// The number of columns that the tiled image contains. Default value: **10**.
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public string Columns { get; set; }

                    /// <summary>
                    /// Indicates whether the single images are retained. Valid values:
                    /// 
                    /// *   **true**: The single images are retained.
                    /// *   **false**: The single images are not retained.
                    /// *   Default value: **true**.
                    /// </summary>
                    [NameInMap("IsKeepCellPic")]
                    [Validation(Required=false)]
                    public string IsKeepCellPic { get; set; }

                    /// <summary>
                    /// The number of rows that the tiled image contains. Default value: **10**.
                    /// </summary>
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public string Lines { get; set; }

                    /// <summary>
                    /// The margin width of the tiled image.
                    /// 
                    /// *   Default value: **0**.
                    /// *   Unit: pixel.
                    /// </summary>
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public string Margin { get; set; }

                    /// <summary>
                    /// The distance between two consecutive single images in the tiled image.
                    /// 
                    /// *   Default value: **0**.
                    /// *   Unit: pixel.
                    /// </summary>
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public string Padding { get; set; }

                }

                /// <summary>
                /// The information about the output file of the tiling job.
                /// </summary>
                [NameInMap("TileOutputFile")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOutputFile TileOutputFile { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOutputFile : TeaModel {
                    /// <summary>
                    /// The OSS bucket that stores the object.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The ID of the region in which the OSS bucket that stores the object is located.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The OSS object that is generated as the output file of the tiling job.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    /// <summary>
                    /// The ARN of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                /// <summary>
                /// The start time for capturing snapshots. Unit: milliseconds.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("TimeArray")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTimeArray TimeArray { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTimeArray : TeaModel {
                    [NameInMap("TimePointList")]
                    [Validation(Required=false)]
                    public List<long?> TimePointList { get; set; }

                }

                /// <summary>
                /// The width of the output snapshot.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// The status of the snapshot job. Valid values:
            /// 
            /// *   **Submitted**: The job is submitted.
            /// *   **Snapshoting**: The job is being processed.
            /// *   **Success**: The job is successful.
            /// *   **Fail**: The job fails.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The number of single images that are contained in the tiled image.
            /// </summary>
            [NameInMap("TileCount")]
            [Validation(Required=false)]
            public string TileCount { get; set; }

            /// <summary>
            /// The custom data.
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
