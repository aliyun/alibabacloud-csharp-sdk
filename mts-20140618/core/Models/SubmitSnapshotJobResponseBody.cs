// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitSnapshotJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19B6D8C5-A5DD-467A-B435-29D393C71E2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the snapshot job.</para>
        /// </summary>
        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public SubmitSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class SubmitSnapshotJobResponseBodySnapshotJob : TeaModel {
            /// <summary>
            /// <para>The error code returned if the job fails. This parameter is not returned if the job is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceContentBad</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The number of snapshots that are captured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-19T03:11:48Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f4e3b9ba9f3840c39d6e288056f0****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The information about the job input.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobInput Input { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobInput : TeaModel {
                /// <summary>
                /// <para>The OSS bucket that stores the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The region in which the OSS bucket resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-location\&quot;</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The OSS object that is used as the input file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.flv</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                /// <summary>
                /// <para>The ARN of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::1:role/testrole</para>
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

            }

            /// <summary>
            /// <para>The message sent by MNS to notify the user of the job result.</para>
            /// </summary>
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobMNSMessageResult : TeaModel {
                /// <summary>
                /// <para>The error code returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource operated InputFile is bad</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the message. This parameter is not returned if the job fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>799454621135656C7F815F198A76****</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

            }

            /// <summary>
            /// <para>The error message returned if the job fails. This parameter is not returned if the job is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource operated InputFile is bad</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the MPS queue to which the snapshot job is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dd3dae411e704030b921e52698e5****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The snapshot configurations.</para>
            /// </summary>
            [NameInMap("SnapshotConfig")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfig SnapshotConfig { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfig : TeaModel {
                /// <summary>
                /// <para>The type of the snapshot. Default value: <b>Normal</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal frames.</description></item>
                /// <item><description><b>intra</b>: I-frames (keyframes).</description></item>
                /// </list>
                /// <remarks>
                /// <para>If the FrameType parameter is set to intra in the request, only keyframes are captured. If no keyframe is found at the specified point in time, the keyframe closest to the specified point in time is captured. Keyframes are captured faster than normal frames if the same snapshot rules are applied.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>intra</para>
                /// </summary>
                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                /// <summary>
                /// <para>The height of the output snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The interval for capturing snapshots.</para>
                /// <list type="bullet">
                /// <item><description>If this parameter is specified in the request, snapshots are captured at intervals. The value must be greater than 0 in the request.</description></item>
                /// <item><description>Unit: seconds.</description></item>
                /// <item><description>Default value: <b>10</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// <para>The number of snapshots. If the Num parameter is set in the request, snapshots are captured at intervals.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public string Num { get; set; }

                /// <summary>
                /// <para>The information about the output file of the snapshot job.</para>
                /// </summary>
                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigOutputFile OutputFile { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigOutputFile : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket that stores the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The OSS region in which the OSS bucket for storing the output snapshot resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-location</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The OSS object that is generated as the output file of the snapshot job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test.png</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::1:role/testrole</para>
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                /// <summary>
                /// <para>The tiling configurations.</para>
                /// </summary>
                [NameInMap("TileOut")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOut TileOut { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOut : TeaModel {
                    /// <summary>
                    /// <para>The height of a single image. The default value is the height of the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public string CellHeight { get; set; }

                    /// <summary>
                    /// <para>The step for selecting a single image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("CellSelStep")]
                    [Validation(Required=false)]
                    public string CellSelStep { get; set; }

                    /// <summary>
                    /// <para>The width of a single image. The default value is the width of the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CellWidth")]
                    [Validation(Required=false)]
                    public string CellWidth { get; set; }

                    /// <summary>
                    /// <para>The background color.</para>
                    /// <list type="bullet">
                    /// <item><description>Default value: <b>black</b>.</description></item>
                    /// <item><description>You can set the Color parameter to a <b>color keyword</b> or <b>random</b> in the request.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If you want to set the background color to black, you can specify the color keyword in one of the following three formats: Black, black, and #000000.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>black</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <para>The number of columns that the tiled image contains. Default value: <b>10</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public string Columns { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the single images are retained. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The single images are retained.</description></item>
                    /// <item><description><b>false</b>: The single images are not retained.</description></item>
                    /// <item><description>Default value: <b>true</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsKeepCellPic")]
                    [Validation(Required=false)]
                    public string IsKeepCellPic { get; set; }

                    /// <summary>
                    /// <para>The number of rows that the tiled image contains. Default value: <b>10</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public string Lines { get; set; }

                    /// <summary>
                    /// <para>The margin width of the tiled image.</para>
                    /// <list type="bullet">
                    /// <item><description>Default value: <b>0</b>.</description></item>
                    /// <item><description>Unit: pixel.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public string Margin { get; set; }

                    /// <summary>
                    /// <para>The distance between two consecutive single images in the tiled image.</para>
                    /// <list type="bullet">
                    /// <item><description>Default value: <b>0</b>.</description></item>
                    /// <item><description>Unit: pixel.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public string Padding { get; set; }

                }

                /// <summary>
                /// <para>The information about the output file of the tiling job.</para>
                /// </summary>
                [NameInMap("TileOutputFile")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOutputFile TileOutputFile { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOutputFile : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket that stores the object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The ID of the region in which the OSS bucket that stores the object is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-location</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The OSS object that is generated as the output file of the tiling job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.png</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    /// <summary>
                    /// <para>The ARN of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::1:role/testrole</para>
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                /// <summary>
                /// <para>The start time for capturing snapshots. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
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
                /// <para>The width of the output snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>The status of the snapshot job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Submitted</b>: The job is submitted.</description></item>
            /// <item><description><b>Snapshoting</b>: The job is being processed.</description></item>
            /// <item><description><b>Success</b>: The job is successful.</description></item>
            /// <item><description><b>Fail</b>: The job fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Snapshoting</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The number of single images that are contained in the tiled image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TileCount")]
            [Validation(Required=false)]
            public string TileCount { get; set; }

            /// <summary>
            /// <para>The custom data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testid-001</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
