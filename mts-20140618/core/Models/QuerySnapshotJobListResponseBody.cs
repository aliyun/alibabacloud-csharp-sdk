// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySnapshotJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The OSS object that is used as the input file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b11c171cced04565b1f38f1ecc39****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The OSS object that is generated as the output file of the tiling job.</para>
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
        /// <para>The ID of the snapshot job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34BCAB31-2833-43A7-9FBD-B34302AB23EQ</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The distance between images.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>0</b>.</description></item>
        /// <item><description>Unit: pixel.</description></item>
        /// </list>
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
                /// <para>You can call this operation to query up to 10 snapshot jobs at a time.</para>
                /// <h2>Limits on QPS</h2>
                /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation. For more information, see <a href="https://www.alibabacloud.com/help/en/apsaravideo-for-media-processing/latest/qps-limit">QPS limit</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The ID of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>The stride of a single image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-30T12:34:29Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The OSS output file of the tiling job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc6cbef8e8d5481ca536f5d2a466****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The number of snapshots that are contained in the tiled image.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobInput Input { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobInput : TeaModel {
                    /// <summary>
                    /// <para>The ID of the snapshot job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The ID of the MPS queue to which the snapshot job was submitted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-location</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The error code returned when the job fails. This parameter is not returned if the job is successfully processed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.flv</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    /// <summary>
                    /// <para>The custom data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::1:role/testrole</para>
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                /// <summary>
                /// <para>The OSS object that is used as the input file.</para>
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobMNSMessageResult MNSMessageResult { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobMNSMessageResult : TeaModel {
                    /// <summary>
                    /// <para>The number of snapshots that were taken.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InvalidParameter</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The OSS bucket that stores the input file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The resource operated InputFile is bad</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The ID of the region in which the input OSS bucket is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>799454621135656C7F815F198A76****</para>
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                /// <summary>
                /// <para>The ARN of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource operated InputFile is bad</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The start time for taking snapshots. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b11c171cced04565b1f38f1ecc39****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The height of a single image. The default value is the height of the output snapshot.</para>
                /// </summary>
                [NameInMap("SnapshotConfig")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfig SnapshotConfig { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfig : TeaModel {
                    /// <summary>
                    /// <para>The ID of the region in which the output OSS bucket is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>intra</para>
                    /// </summary>
                    [NameInMap("FrameType")]
                    [Validation(Required=false)]
                    public string FrameType { get; set; }

                    /// <summary>
                    /// <para>The number of snapshots to take. If the Num parameter is set in the request, snapshots are taken at intervals.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The OSS object that is generated as the output file of the snapshot job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    /// <summary>
                    /// <para>The status of the snapshot job. </para>
                    /// <list type="bullet">
                    /// <item><description><b>Submitted</b>: The job was submitted.</description></item>
                    /// <item><description><b>Snapshoting</b>: The job is being processed.</description></item>
                    /// <item><description><b>Success</b>: The job was successfully processed.</description></item>
                    /// <item><description><b>Fail</b>: The job failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public string Num { get; set; }

                    /// <summary>
                    /// <para>The OSS output file of the tiling job.</para>
                    /// </summary>
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigOutputFile OutputFile { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigOutputFile : TeaModel {
                        /// <summary>
                        /// <para>The OSS bucket that stores the output file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The ID of the region in which the output OSS bucket is located.</para>
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
                    /// <para>The margin width of the tiled image.</para>
                    /// <list type="bullet">
                    /// <item><description>Default value: <b>0</b>.</description></item>
                    /// <item><description>Unit: pixel.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("TileOut")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOut TileOut { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOut : TeaModel {
                        /// <summary>
                        /// <para>The interval for taking snapshots.</para>
                        /// <list type="bullet">
                        /// <item><description>If this Interval parameter is specified in the request, snapshots are taken at intervals. The value must be greater than 0.</description></item>
                        /// <item><description>Unit: seconds.</description></item>
                        /// <item><description>Default value: <b>10</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("CellHeight")]
                        [Validation(Required=false)]
                        public string CellHeight { get; set; }

                        /// <summary>
                        /// <para>The number of rows that the tiled image can contain. Default value: <b>10</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("CellSelStep")]
                        [Validation(Required=false)]
                        public string CellSelStep { get; set; }

                        /// <summary>
                        /// <para>The type of the snapshot. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal frames.</description></item>
                        /// <item><description><b>intra</b>: I-frames.</description></item>
                        /// <item><description>Default value: <b>intra</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("CellWidth")]
                        [Validation(Required=false)]
                        public string CellWidth { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the single images are retained. Default value: <b>true</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>black</para>
                        /// </summary>
                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        /// <summary>
                        /// <para>The height of the output snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public string Columns { get; set; }

                        /// <summary>
                        /// <para>The Object Storage Service (OSS) output file of the snapshot job.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsKeepCellPic")]
                        [Validation(Required=false)]
                        public string IsKeepCellPic { get; set; }

                        /// <summary>
                        /// <para>The Alibaba Cloud Resource Name (ARN) of the specified RAM role. Format: acs:ram::$accountID:role/$roleName.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Lines")]
                        [Validation(Required=false)]
                        public string Lines { get; set; }

                        /// <summary>
                        /// <para>The width of the output snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Margin")]
                        [Validation(Required=false)]
                        public string Margin { get; set; }

                        /// <summary>
                        /// <para>The number of columns that the tiled image can contain. Default value: <b>10</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Padding")]
                        [Validation(Required=false)]
                        public string Padding { get; set; }

                    }

                    /// <summary>
                    /// <para>The error message returned when the job fails. This parameter is not returned if the job is successfully processed.</para>
                    /// </summary>
                    [NameInMap("TileOutputFile")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOutputFile TileOutputFile { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOutputFile : TeaModel {
                        /// <summary>
                        /// <para>The error code returned when the job fails. This parameter is not returned if the job is successfully processed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The error message returned when the job fails. This parameter is not returned if the job is successfully processed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-location</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The ID of the message. This parameter is not returned if the job fails.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.png</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        /// <summary>
                        /// <para>The message sent by MNS to notify the user of the job result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:ram::1:role/testrole</para>
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    /// <summary>
                    /// <para>The width of a single image. The default value is the width of the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
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
                    /// <para>The OSS bucket that stores the output file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The information about the job input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Snapshoting</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The snapshot job IDs that do not exist. This parameter is not returned if all specified snapshot jobs are found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("TileCount")]
                [Validation(Required=false)]
                public string TileCount { get; set; }

                /// <summary>
                /// <para>The token that is used to retrieve the next page of the query results. The value is a 32-bit UUID. If the returned query results cannot be displayed within one page, this parameter is returned. The value of this parameter is updated for each query.</para>
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

}
