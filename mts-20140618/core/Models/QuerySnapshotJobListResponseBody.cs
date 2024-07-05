// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySnapshotJobListResponseBody : TeaModel {
        /// <summary>
        /// The OSS object that is used as the input file.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The OSS object that is generated as the output file of the tiling job.
        /// </summary>
        [NameInMap("NonExistSnapshotJobIds")]
        [Validation(Required=false)]
        public QuerySnapshotJobListResponseBodyNonExistSnapshotJobIds NonExistSnapshotJobIds { get; set; }
        public class QuerySnapshotJobListResponseBodyNonExistSnapshotJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the snapshot job.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The distance between images.
        /// 
        /// *   Default value: **0**.
        /// *   Unit: pixel.
        /// </summary>
        [NameInMap("SnapshotJobList")]
        [Validation(Required=false)]
        public QuerySnapshotJobListResponseBodySnapshotJobList SnapshotJobList { get; set; }
        public class QuerySnapshotJobListResponseBodySnapshotJobList : TeaModel {
            [NameInMap("SnapshotJob")]
            [Validation(Required=false)]
            public List<QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJob> SnapshotJob { get; set; }
            public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJob : TeaModel {
                /// <summary>
                /// You can call this operation to query up to 10 snapshot jobs at a time.
                /// 
                /// 
                /// ## Limits on QPS
                /// 
                /// You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation. For more information, see [QPS limit](https://www.alibabacloud.com/help/en/apsaravideo-for-media-processing/latest/qps-limit).
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// The stride of a single image.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The OSS output file of the tiling job.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The number of snapshots that are contained in the tiled image.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobInput Input { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobInput : TeaModel {
                    /// <summary>
                    /// The ID of the snapshot job.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The ID of the MPS queue to which the snapshot job was submitted.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The error code returned when the job fails. This parameter is not returned if the job is successfully processed.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    /// <summary>
                    /// The custom data.
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                /// <summary>
                /// The OSS object that is used as the input file.
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobMNSMessageResult MNSMessageResult { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobMNSMessageResult : TeaModel {
                    /// <summary>
                    /// The number of snapshots that were taken.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The OSS bucket that stores the input file.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The ID of the region in which the input OSS bucket is located.
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                /// <summary>
                /// The ARN of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The start time for taking snapshots. Unit: milliseconds.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The height of a single image. The default value is the height of the output snapshot.
                /// </summary>
                [NameInMap("SnapshotConfig")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfig SnapshotConfig { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfig : TeaModel {
                    /// <summary>
                    /// The ID of the region in which the output OSS bucket is located.
                    /// </summary>
                    [NameInMap("FrameType")]
                    [Validation(Required=false)]
                    public string FrameType { get; set; }

                    /// <summary>
                    /// The number of snapshots to take. If the Num parameter is set in the request, snapshots are taken at intervals.
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// The OSS object that is generated as the output file of the snapshot job.
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    /// <summary>
                    /// The status of the snapshot job. 
                    /// 
                    /// - **Submitted**: The job was submitted.
                    /// - **Snapshoting**: The job is being processed.
                    /// - **Success**: The job was successfully processed.
                    /// - **Fail**: The job failed.
                    /// </summary>
                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public string Num { get; set; }

                    /// <summary>
                    /// The OSS output file of the tiling job.
                    /// </summary>
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigOutputFile OutputFile { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigOutputFile : TeaModel {
                        /// <summary>
                        /// The OSS bucket that stores the output file.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The ID of the region in which the output OSS bucket is located.
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
                    /// The margin width of the tiled image.
                    /// 
                    /// *   Default value: **0**.
                    /// *   Unit: pixel.
                    /// </summary>
                    [NameInMap("TileOut")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOut TileOut { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOut : TeaModel {
                        /// <summary>
                        /// The interval for taking snapshots.
                        /// 
                        /// *   If this Interval parameter is specified in the request, snapshots are taken at intervals. The value must be greater than 0.
                        /// *   Unit: seconds.
                        /// *   Default value: **10**.
                        /// </summary>
                        [NameInMap("CellHeight")]
                        [Validation(Required=false)]
                        public string CellHeight { get; set; }

                        /// <summary>
                        /// The number of rows that the tiled image can contain. Default value: **10**.
                        /// </summary>
                        [NameInMap("CellSelStep")]
                        [Validation(Required=false)]
                        public string CellSelStep { get; set; }

                        /// <summary>
                        /// The type of the snapshot. Valid values:
                        /// 
                        /// *   **normal**: normal frames.
                        /// *   **intra**: I-frames.
                        /// *   Default value: **intra**.
                        /// </summary>
                        [NameInMap("CellWidth")]
                        [Validation(Required=false)]
                        public string CellWidth { get; set; }

                        /// <summary>
                        /// Indicates whether the single images are retained. Default value: **true**.
                        /// </summary>
                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        /// <summary>
                        /// The height of the output snapshot.
                        /// </summary>
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public string Columns { get; set; }

                        /// <summary>
                        /// The Object Storage Service (OSS) output file of the snapshot job.
                        /// </summary>
                        [NameInMap("IsKeepCellPic")]
                        [Validation(Required=false)]
                        public string IsKeepCellPic { get; set; }

                        /// <summary>
                        /// The Alibaba Cloud Resource Name (ARN) of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.
                        /// </summary>
                        [NameInMap("Lines")]
                        [Validation(Required=false)]
                        public string Lines { get; set; }

                        /// <summary>
                        /// The width of the output snapshot.
                        /// </summary>
                        [NameInMap("Margin")]
                        [Validation(Required=false)]
                        public string Margin { get; set; }

                        /// <summary>
                        /// The number of columns that the tiled image can contain. Default value: **10**.
                        /// </summary>
                        [NameInMap("Padding")]
                        [Validation(Required=false)]
                        public string Padding { get; set; }

                    }

                    /// <summary>
                    /// The error message returned when the job fails. This parameter is not returned if the job is successfully processed.
                    /// </summary>
                    [NameInMap("TileOutputFile")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOutputFile TileOutputFile { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOutputFile : TeaModel {
                        /// <summary>
                        /// The error code returned when the job fails. This parameter is not returned if the job is successfully processed.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The error message returned when the job fails. This parameter is not returned if the job is successfully processed.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The ID of the message. This parameter is not returned if the job fails.
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        /// <summary>
                        /// The message sent by MNS to notify the user of the job result.
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    /// <summary>
                    /// The width of a single image. The default value is the width of the output snapshot.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("TimeArray")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTimeArray TimeArray { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTimeArray : TeaModel {
                        [NameInMap("TimePointList")]
                        [Validation(Required=false)]
                        public List<long?> TimePointList { get; set; }

                    }

                    /// <summary>
                    /// The OSS bucket that stores the output file.
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The snapshot job IDs that do not exist. This parameter is not returned if all specified snapshot jobs are found.
                /// </summary>
                [NameInMap("TileCount")]
                [Validation(Required=false)]
                public string TileCount { get; set; }

                /// <summary>
                /// The token that is used to retrieve the next page of the query results. The value is a 32-bit UUID. If the returned query results cannot be displayed within one page, this parameter is returned. The value of this parameter is updated for each query.
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

    }

}
